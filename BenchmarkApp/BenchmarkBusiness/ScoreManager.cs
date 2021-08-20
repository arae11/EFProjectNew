using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkData;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkBusiness
{
    public class ScoreManager
    {
        public User SelectedUser { get; set; }
        public void SetSelectedUser(object selectedItem)
        {
            SelectedUser = (User)selectedItem;
        }


        public int score { get; set; }

        public void UpdateScore(string username, int score)
        {
            using (var db = new BenchmarkContext())
            {
                var query = db.Scores.Include(s => s.User).Where(s => s.User.Username == username);
                if (query.Count() == 1)
                {
                    if (query.FirstOrDefault().HighScore < score)
                    {
                        query.FirstOrDefault().HighScore = score;
                    }
                    query.FirstOrDefault().NewScore = score;
                }
                else
                {
                    Score newScore = new Score() { NewScore = score, HighScore = score };
                    db.Users.Where(u => u.Username == username).FirstOrDefault().Scores.Add(newScore);
                }
                db.SaveChanges();
            }
        }

        public class ScoreQuery
        {
            public virtual string Username { get; set; }
            public virtual int NewScore { get; set; }
            public virtual int HighScore { get; set; }

            public override string ToString()
            {
                return $"{Username} {NewScore} {HighScore}";
            }
        }

        public static List<ScoreQuery> PopulateLeaderboard()
        {
            using (var db = new BenchmarkContext())
            {
                var scoreQuery =
                    from s in db.Scores
                    join u in db.Users on s.User.UserId equals u.UserId
                    where s.NewScore != null
                    select new ScoreQuery { Username = s.User.Username, NewScore = s.NewScore, HighScore = s.HighScore };
                return scoreQuery.ToList();
            }
        }


    }
}
