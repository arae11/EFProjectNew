using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BenchmarkWPF
{
    class WindowNavigationManager : Window
    {
        public void ScoreScreen()
        {
            BenchmarkWPF.Scores goToScores = new Scores();
            goToScores.Show();
            this.Close();
        }

        public void HomePage()
        {
            HomePage returnToHome = new HomePage();
            returnToHome.Show();
            this.Close();
        }
    }
}
