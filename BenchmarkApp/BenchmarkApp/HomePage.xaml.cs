using BenchmarkApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BenchmarkWPF
{
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, RoutedEventArgs e)
        {
            VerbalMemoryE goToEasy = new VerbalMemoryE();
            goToEasy.Show();
            this.Close();
        }

        private void btnHard_Click(object sender, RoutedEventArgs e)
        {
            VerbalMemoryH goToHard = new VerbalMemoryH();
            goToHard.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow returnToMain = new MainWindow();
            returnToMain.Show();
            this.Close();
        }

        private void btnScores_Click(object sender, RoutedEventArgs e)
        {
            Scores goToScores = new Scores();
            goToScores.Show();
            this.Close();
        }
    }
}
