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
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnVisualMemory_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Press 'New' if the word on the screen hasn't appeared before. Press 'Seen' if it has. If you press the wrong answer 3 times the game is over.");
            VisualMemory goToVisual = new VisualMemory();
            goToVisual.Show();
            this.Close();
        }

        private void btnNumberMemory_Click(object sender, RoutedEventArgs e)
        {
            NumberMemory goToNumber = new NumberMemory();
            goToNumber.Show();
            this.Close();
        }

        private void btnArithmeticTest_Click(object sender, RoutedEventArgs e)
        {
            ArithmeticTest goToArithmetic = new ArithmeticTest();
            goToArithmetic.Show();
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
