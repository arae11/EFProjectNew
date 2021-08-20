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

        private void PopulateLeaderboard()
        {
            ScoreBox.ItemsSource = _uM.RetrieveAll();
        }

        public Scores()
        {
            InitializeComponent();
            PopulateLeaderboard();
        }

        

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            HomePage returnToHome = new HomePage();
            returnToHome.Show();
            this.Close();
        }

        private void ScoreBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ScoreBox.SelectedItem != null)
            {
                _uM.SetSelectedUser(ScoreBox.SelectedItem);
                PopulateLeaderboard();
            }

        }
    }
}
