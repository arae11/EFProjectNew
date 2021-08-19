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
    /// Interaction logic for NumberMemory.xaml
    /// </summary>
    public partial class NumberMemory : Window
    {
        public int score = 0;
        
        private string Level(int lvl)
        {
            
            Random rng = new Random();
            int number = rng.Next(10^(lvl-1), 10^lvl);
            return number.ToString();
        }
        
        private void Answer()
        {
            int level = 1;
            while (true)
            {
                string storedNumber = Level(level);
                lblDisplay.Content = storedNumber;
                if (tbxInput.Equals(storedNumber))
                {
                    score++;
                    level++;
                }
                else
                {
                    // put score into database
                    Console.WriteLine(score);
                    break;
                }
            }
        }






        public NumberMemory()
        {
            InitializeComponent();
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            HomePage returnToHome = new HomePage();
            returnToHome.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Answer();
        }
    }
}
