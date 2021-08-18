using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkData
{
    public partial class User
    {
        public User()
        {
            Scores = new HashSet<Score>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
