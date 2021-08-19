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
using BenchmarkBusiness;

namespace BenchmarkWPF
{
    /// <summary>
    /// Interaction logic for VisualMemory.xaml
    /// </summary>
    public partial class VisualMemory : Window
    {
        private VisualMemoryManager _vmm;
        private ScoreManager _sm;

        private string username;
        private int score;
        
        private void GameOver(string username)
        {
            if (_vmm.GameOver(username) == true) 
            {
                MessageBox.Show("Game Over");
                ScoreScreen();
            }
        }

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

        public VisualMemory()
        {
            InitializeComponent();
            username = UserManager.CurrentUsername;
            _vmm = new VisualMemoryManager();
            _sm = new ScoreManager();
            tbxWord.Text = _vmm.NewWordEasy();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            HomePage();
        }

        private void btnSeen_Click(object sender, RoutedEventArgs e)
        {
            if (_vmm.seenWords.Contains(tbxWord.Text))
            {
                _vmm.IncreaseScore();
            }
            else
            {
                _vmm.DecreaseLives();
            }
            tbxWord.Text = _vmm.NewWordEasy();
            lblScore.Content = $"Score: {_vmm.score}";
            lblLives.Content = $"Lives: {_vmm.lives}";
            GameOver(username);
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            if (!_vmm.seenWords.Contains(tbxWord.Text))
            {
                _vmm.IncreaseScore();
            }
            else
            {
                _vmm.DecreaseLives();
            }
            _vmm.seenWords.Add(tbxWord.Text);
            tbxWord.Text = _vmm.NewWordEasy();
            lblScore.Content = $"Score: {_vmm.score}";
            lblLives.Content = $"Lives: {_vmm.lives}";
            GameOver(username);
        }

        private void tbxWord_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
