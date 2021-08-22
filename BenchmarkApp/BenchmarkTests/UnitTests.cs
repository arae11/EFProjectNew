using NUnit.Framework;
using BenchmarkData;
using BenchmarkBusiness;
using System.Linq;

namespace BenchmarkTests
{
    public class UserTests
    {
        UserManager _userManager;
        [SetUp]
        public void Setup()
        {
            _userManager = new UserManager();
            using (var db = new BenchmarkContext())
            {
                var selectedUser =
                    from u in db.Users
                    where u.Username == "TestUser"
                    select u;

                db.Users.RemoveRange(selectedUser);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewUserIsAdded_TheNumberOfUsersIncreasesBy1()
        {
            using (var db = new BenchmarkContext())
            {
                var numberOfUsersBefore = db.Users.Count();
                _userManager.CreateUser("TestUser", "123");
                var numberOfUsersAfter = db.Users.Count();

                Assert.That(numberOfUsersBefore + 1, Is.EqualTo(numberOfUsersAfter));
            }
        }

        [Test]
        public void WhenANewUserIsAdded_TheirDetailsAreCorrect()
        {
            using (var db = new BenchmarkContext())
            {
                _userManager.CreateUser("TestUser", "123");
                var query =
                        db.Users.FirstOrDefault(u => u.Username == "TestUser");
                Assert.That(query.Username, Is.EqualTo("TestUser"));
                Assert.That(query.Password, Is.EqualTo("123"));
            }
        }

        [Test]
        public void WhenAUserIsUpdated_TheDatabaseIsUpdated()
        {
            using (var db = new BenchmarkContext())
            {
                _userManager.CreateUser("TestUser", "123");
                _userManager.UpdateUser("TestUser", "456");

                var query =
                    db.Users.FirstOrDefault(u => u.Username == "TestUser");
                if (query != null)
                {
                    Assert.That(query.Password, Is.EqualTo("456"));
                }
            }
        }

        [Test]
        public void WhenAUserIsUpdated_SelectedUserIsUpdated()
        {
            _userManager.CreateUser("TestUser", "123");
            _userManager.UpdateUser("TestUser", "456");
            Assert.That(_userManager.SelectedUser.Password, Is.EqualTo("456"));
        }

        [Test]
        public void WhenAUserIsNotInTheDatabase_Update_ReturnsFalse()
        {
            using (var db = new BenchmarkContext())
            {
                var result = _userManager.UpdateUser("TestUser", "123");
                Assert.That(result, Is.False);
            }
        }

        [Test]
        public void WhenAUserIsRemoved_TheNumberOfUsersDecreasesBy1()
        {
            using (var db = new BenchmarkContext())
            {
                var newUser = new User()
                {
                    Username = "TestUser",
                    Password = "123"
                };

                db.Users.Add(newUser);
                db.SaveChanges();
                var numberOfUsersBefore = db.Users.ToList().Count();
                _userManager.DeleteUser("TestUser");
                var numberOfUsersAfter = db.Users.ToList().Count();
                Assert.That(numberOfUsersBefore - 1, Is.EqualTo(numberOfUsersAfter));
            }
        }

        [Test]
        public void WhenAUserIsRemoved_TheyAreNoLongerInTheDatabase()
        {
            using (var db = new BenchmarkContext())
            {
                var newUser = new User()
                {
                    Username = "TestUser",
                    Password = "123"
                };

                db.Users.Add(newUser);
                db.SaveChanges();
            }
            _userManager.DeleteUser("TestUser");
            using (var db = new BenchmarkContext())
            {
                var result = db.Users.Where(u => u.Username == "TestUser").FirstOrDefault();
                Assert.That(result, Is.Null);
            }
        }

        [TearDown]
        public void TearDown()
        {
            using (var db = new BenchmarkContext())
            {
                var selectedUsers =
                from u in db.Users
                where u.Username == "TestUser"
                select u;

                db.Users.RemoveRange(selectedUsers);
                db.SaveChanges();
            }
        }
    }
}