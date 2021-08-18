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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BenchmarkBusiness;
using BenchmarkWPF;

namespace BenchmarkApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void tbxUserName(object sender, TextChangedEventArgs e)
        {
        }

        private void pbxPassword(object sender, TextChangedEventArgs e)
        {
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var userManager = new UserManager();
            var username = usernameField.Text;
            var password = passwordField.Password;
            var userCheck = userManager.LogInCheck(username, password);
            if (userCheck == true)
            {
                HomePage sendToHome = new HomePage();
                sendToHome.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterUser sendToRegister = new RegisterUser();
            sendToRegister.Show();
            this.Close();
        }
    }
}
