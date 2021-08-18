﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BenchmarkData;

namespace BenchmarkBusiness
{
    public class UserManager
    {
        public User SelectedUser { get; set; }

        public void SetSelectedUser(object selectedItem)
        {
            SelectedUser = (User)selectedItem;
        }

        public List<User> RetrieveAll()
        {
            using (var db = new BenchmarkContext())
            {
                return db.Users.ToList();
            }
        }

        public void CreateUser(string username, string password)
        {
            var newUser = new User() { Username = username, Password = password };
            using (var db = new BenchmarkContext())
            {
                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }

        public bool UpdateUser(int userId, string username, string password)
        {
            using (var db = new BenchmarkContext())
            {
                var user = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
                if (user == null)
                {
                    Debug.WriteLine($"User {userId} not found");
                    return false;
                }
                user.Username = username;
                user.Password = password;
                // write changes to database
                try
                {
                    db.SaveChanges();
                    SelectedUser = user;
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Error updating {userId}");
                    return false;
                }
            }
            return true;
        }

        public bool DeleteUser(int userId)
        {
            using (var db = new BenchmarkContext())
            {
                var user = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
                if (user == null)
                {
                    Debug.WriteLine($"User {userId} not found");
                    return false;
                }
                db.Users.RemoveRange(user);
                db.SaveChanges();
            }
            return true;
        }

        public bool LogInCheck(string username, string password)
        {
            var users = RetrieveAll();
            var existingUser = users.Where(u => u.Username == username).FirstOrDefault();
            if (existingUser != null)
            {
                if (existingUser.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool UsernameCheck(string username)
        {
            var users = RetrieveAll();
            var checkUsername = users.Where(u => u.Username == username).FirstOrDefault();
            if (checkUsername != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
