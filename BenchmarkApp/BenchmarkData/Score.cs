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
        public string Difficulty { get; set; }
        public int NewScore { get; set; }
        public int HighScore { get; set; }

        public virtual User User { get; set; }
    }
}
