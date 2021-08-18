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

        private string WordBank()
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

        public string NewWord()
        {
            var newWord = WordBank();
            return newWord;
        }

        public void IncreaseScore()
        {
            score++;
        }

        public void DecreaseLives()
        {
            lives--;
        }

        public Boolean GameOver()
        {
            if (lives == 0)
            {
                return true;
            }
            return false;
        }

    }
}
