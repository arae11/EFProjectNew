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
using BenchmarkApp;
using BenchmarkBusiness;

namespace BenchmarkWPF
{
    /// <summary>
    /// Interaction logic for RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : Window
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void BackToLogin()
        {
            MainWindow returnToMain = new MainWindow();
            returnToMain.Show();
            this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var userManager = new UserManager();
            var username = usernameField.Text;
            var password = passwordField.Password;
            var existingUser = userManager.UsernameCheck(username);
            if (existingUser)
            {
                MessageBox.Show("Invalid username");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Invalid password");
            }
            else
            {
                userManager.CreateUser(username, password);
                MessageBox.Show("Account creation successful");
                BackToLogin();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            BackToLogin();
        }
    }
}
