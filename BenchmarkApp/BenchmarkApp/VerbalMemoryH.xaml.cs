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
    public partial class VerbalMemoryH : Window
    {
        private VerbalMemoryManager _vMM;
        private ScoreManager _sM;
        

        private string username;
        private int score;
        
        private void GameOver(string username)
        {
            if (_vMM.GameOver(username) == true) 
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

        public VerbalMemoryH()
        {
            InitializeComponent();
            username = UserManager.CurrentUsername;
            _vMM = new VerbalMemoryManager();
            _sM = new ScoreManager();
            tbxWord.Text = _vMM.NewWordHard();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            HomePage();
        }

        private void btnSeen_Click(object sender, RoutedEventArgs e)
        {
            if (_vMM.seenWords.Contains(tbxWord.Text))
            {
                _vMM.IncreaseScore();
            }
            else
            {
                _vMM.DecreaseLives();
            }
            tbxWord.Text = _vMM.NewWordHard();
            lblScore.Content = $"Score: {_vMM.score}";
            lblLives.Content = $"Lives: {_vMM.lives}";
            GameOver(username);
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            if (!_vMM.seenWords.Contains(tbxWord.Text))
            {
                _vMM.IncreaseScore();
            }
            else
            {
                _vMM.DecreaseLives();
            }
            _vMM.seenWords.Add(tbxWord.Text);
            tbxWord.Text = _vMM.NewWordHard();
            lblScore.Content = $"Score: {_vMM.score}";
            lblLives.Content = $"Lives: {_vMM.lives}";
            GameOver(username);
        }

        private void tbxWord_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
