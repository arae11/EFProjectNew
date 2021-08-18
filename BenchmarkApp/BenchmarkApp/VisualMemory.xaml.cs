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
    /// Interaction logic for VisualMemory.xaml
    /// </summary>
    public partial class VisualMemory : Window
    {
        private VisualMemoryManager _vmm;
        
        private void GameOver()
        {
            if (_vmm.GameOver() == true) 
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
            _vmm = new VisualMemoryManager();
            tbxWord.Text = _vmm.NewWord();
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
            tbxWord.Text = _vmm.NewWord();
            lblScore.Content = $"Score: {_vmm.score}";
            lblLives.Content = $"Lives: {_vmm.lives}";
            GameOver();
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
            tbxWord.Text = _vmm.NewWord();
            lblScore.Content = $"Score: {_vmm.score}";
            lblLives.Content = $"Lives: {_vmm.lives}";
            GameOver();
        }

        private void tbxWord_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
