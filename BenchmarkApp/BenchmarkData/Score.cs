using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkData
{
    public partial class Score
    {
        public int ScoreId { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public int TotalScore { get; set; }

        public virtual Game Games { get; set; }
        public virtual User User { get; set; }
    }
}
