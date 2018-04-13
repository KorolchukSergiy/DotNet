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
using BLL;
using MahApps.Metro.Controls;

namespace DotNet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Progress.Visibility = Visibility.Hidden;
        }

        private void RegNewProvider_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BlockControl()
        {
            ExitButton.IsEnabled = false;
            LoginButton.IsEnabled = false;
            LogInBox.IsEnabled = false;
            passwordBox.IsEnabled = false;
            RegNewProvider.IsEnabled = false;
           
        }

        private void UnBlockControl()
        {
            ExitButton.IsEnabled = true;
            LoginButton.IsEnabled = true;
            LogInBox.IsEnabled = true;
            passwordBox.IsEnabled = true;
            RegNewProvider.IsEnabled = true;
        }

        private async void LogIn_Click(object sender, RoutedEventArgs e)
        {
            BlockControl();
            string login = LogInBox.Text;
            string password = passwordBox.Password;
            Progress.Visibility = Visibility.Visible;
            BllPost LoginPost = await Task.Run(() =>
              {
                  Logic BllLogic = new Logic();
                  return BllLogic.GetPostLogin(login, password);
              });
            CheckLogin(LoginPost);
            Progress.Visibility = Visibility.Hidden;
            if(LoginPost!=null)
            {
                MessageBox.Show(LoginPost.Name);
            }
            UnBlockControl();
        }

        private void CheckLogin(BllPost LoginPost)
        {
           
        }



        private void MetroWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter)
            {
                LogIn_Click(null, null);
            }
        }
    }
}
