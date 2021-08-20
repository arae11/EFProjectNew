using BenchmarkBusiness;
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
    /// Interaction logic for Scores.xaml
    /// </summary>
    public partial class Scores : Window
    {
        private ScoreManager _sM = new ScoreManager();
        private UserManager _uM = new UserManager();

        public Scores()
        {
            InitializeComponent();
            _sM = new ScoreManager();
            var list = ScoreManager.PopulateLeaderboard();
            ScoreBox.ItemsSource = list;
        }

        

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            HomePage returnToHome = new HomePage();
            returnToHome.Show();
            this.Close();
        }
        

    }
}
