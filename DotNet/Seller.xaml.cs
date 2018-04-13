using System;
using System.Drawing;
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
using MahApps.Metro.Controls;
using System.IO;
using System.Data.Entity;
using BLL;
using System.Collections.ObjectModel;
using BLL.DataModel;

namespace DotNet
{
    /// <summary>
    /// Логика взаимодействия для Seller.xaml
    /// </summary>
    public partial class Seller : MetroWindow
    {
        ObservableCollection<testclass> list = new ObservableCollection<testclass>();
        public Seller()
        {
            InitializeComponent();
     

            //list.Add( new testclass { Name = "dsaf", Image = new BitmapImage(new Uri( @"I7700.jpg",UriKind.RelativeOrAbsolute))});
            //CpusDataGrid.ItemsSource = list;
          
            ShowCloseButton = false;
            Logic blllogic = new Logic();
            List<BllCpu> mylist = blllogic.GetListBllCpu();
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
