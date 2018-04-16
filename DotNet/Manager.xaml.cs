using MahApps.Metro.Controls;
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
using BLL;
using BLL.DataModel;

namespace DotNet
{
    /// <summary>
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : MetroWindow
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow.exit = true;
            Close();
        }
    }
}
