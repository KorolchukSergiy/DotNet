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

        private async void LogIn_Click(object sender, RoutedEventArgs e)
        {
            string login = LogInBox.Text;
            string password = passwordBox.Password;
            Progress.Visibility = Visibility.Visible;
            BllPost LoginPost = await Task.Run(() =>
              {
                  Logic BLLLogic = new Logic();
                  return BLLLogic.GetPostLogin(login, password);
              });
            CheckLogin(LoginPost);
            Progress.Visibility = Visibility.Hidden;
        }

        private void CheckLogin(BllPost LoginPost)
        {
           
        }
    }
}
