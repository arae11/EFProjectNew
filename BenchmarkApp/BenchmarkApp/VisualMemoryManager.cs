using BenchmarkBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BenchmarkWPF
{
    class VisualMemoryManager
    {
        public List<string> seenWords = new List<string>();
        public int lives = 3;
        public int score = 0;

        private ScoreManager _sm = new ScoreManager();

        private string WordBankEasy()
        {
            string[] array = new string[]
            { "PEACE", "PLUG", "DRIVE", "RALLY", "PIE", "WASTE", "DASH", "MINE", "BLAME", "BED",
              "CAKE", "CREW", "PAPER", "CONGO", "GATE", "PAIR", "COPY", "STOOL", "GOWN", "PULL",
              "PUNCH", "MUGGY", "BERRY", "POLE", "BOLD", "DREAM", "CLOSE", "HELP", "MONTH", "VAIN",
              "EVEN", "JAM", "CRAFT", "RICE", "SPY", "CHORD", "LIMIT", "BELT", "CROWD", "FENCE",
              "CAFE", "BRAID", "STOOP", "STOP", "SLUMP", "BACK", "CUP", "SNAP", "ROB", "WEST"};
            Random rng = new Random();
            int word = rng.Next(0, 50);
            return array[word];
        }

        private string WordBankHard()
        {
            string[] array = new string[]
            { "OVERLOOK", "CURRENT", "DISCIPLINE", "TELEPHONE", "CONTRARY", "AMPUTATE", "CONFIDENCE", "EXECUTE", "SKELETON", "PRIMARY",
              "RECESSION", "MARRIAGE", "REHEARSAL", "CONGRESS", "CUCUMBER", "EARTHFLAX", "NEGLIGENCE", "SANCTUARY", "CATHEDRAL", "EXPRESS",
              "FEDERATION", "CATEGORY", "PRESSURE", "WILDERNESS", "GRIMACE", "SENTIMENT", "HARMONY", "RUBBISH", "MENTION", "FLOURISH",
              "CONSUMPTION", "CHANNEL", "GIRLFRIEND", "OPERATIONAL", "ABSORPTION", "ADSORPTION", "SPECIMEN", "EXCITEMENT", "CAMPAIGN", "SEPARATE",
              "INVISIBLE", "COURTESY", "CIGARETTE", "OPPOSITE", "AMBIGUITY", "PERSONALITY", "RECORDING", "NEUTRAL", "PUBLISHER", "SOFTWARE"};
            Random rng = new Random();
            int word = rng.Next(0, 50);
            return array[word];
        }

        public string NewWordEasy()
        {
            var newWordE = WordBankEasy();
            return newWordE;
        }

        public string NewWordHard()
        {
            var newWordH = WordBankHard();
            return newWordH;
        }

        //public bool Difficulty()
        //{
            
        //}


        public void IncreaseScore()
        {
            score++;
        }

        public void DecreaseLives()
        {
            lives--;
        }

        public bool GameOver(string username)
        {
            if (lives == 0)
            {
                _sm.UpdateScore(username, score);
                return true;
            }
            return false;
        }


    }
}
