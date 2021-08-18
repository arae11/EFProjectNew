using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkData
{
    public class Game
    {
        public Game()
        {
            Scores = new HashSet<Score>();
        }

        public int GameId { get; set; }
        public string GameType { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
