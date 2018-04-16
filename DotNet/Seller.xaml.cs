using System;
//using System.Drawing;
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
        List<BllCpu> ListBllCpu;
        List<BllMotherBoard> ListBllMotherBoard;
        public Seller()
        {
            InitializeComponent();

            ShowCloseButton = false;          
        }

        private void SellerWindoowLoaded(object sender, RoutedEventArgs e)
        {
            Logic blllogic = new Logic();
            ListBllCpu = blllogic.GetListBllCpu();

            AddBoxInCpuProducerTree();
            AddBoxInCpuCoreTree();
            AddBoxInCpuSocketTree();
            AddBoxInCpuVideoTree();
            CpusDataGrid.ItemsSource = ListBllCpu;
            

        }

        private void AddBoxInCpuProducerTree()
        {
           
            foreach (var item in ListBllCpu.Select(x => x.Producer).Distinct().ToList())
            {
                CheckBox TmpCheckBox = new CheckBox
                {
                    Content = item,
                    Background = Brushes.Transparent,
                    Foreground = Brushes.GreenYellow,
                    IsChecked = true
                };
                TmpCheckBox.Checked += CheckCpu;
                TmpCheckBox.Unchecked += CheckCpu;
                CpuProducerTree.Items.Add(TmpCheckBox);
            }
        }

        private void AddBoxInCpuCoreTree()
        {
            foreach (var item in ListBllCpu.Select(x => x.Core).Distinct().ToList())
            {
                CheckBox TmpCheckBox = new CheckBox
                {
                    Content = item,
                    Background = Brushes.Transparent,
                    Foreground = Brushes.GreenYellow,
                    IsChecked = true
                };
                TmpCheckBox.Checked += CheckCpu;
                TmpCheckBox.Unchecked += CheckCpu;
                CpuCoreTree.Items.Add(TmpCheckBox);
            }
        }

        private void AddBoxInCpuSocketTree()
        {
            foreach (var item in ListBllCpu.Select(x => x.Socket).Distinct().ToList())
            {
                CheckBox TmpCheckBox = new CheckBox
                {
                    Content = item,
                    Background = Brushes.Transparent,
                    Foreground = Brushes.GreenYellow,
                    IsChecked = true
                };
                TmpCheckBox.Checked += CheckCpu;
                TmpCheckBox.Unchecked += CheckCpu;
                CpuSocketTree.Items.Add(TmpCheckBox);
            }
        }

        private void AddBoxInCpuVideoTree()
        {
            foreach (var item in ListBllCpu.Select(x => x.Video).Distinct().ToList())
            {
                CheckBox TmpCheckBox = new CheckBox
                {
                    Content = item,
                    Background = Brushes.Transparent,
                    Foreground = Brushes.GreenYellow,
                    IsChecked = true
                };
                TmpCheckBox.Checked += CheckCpu;
                TmpCheckBox.Unchecked += CheckCpu;
                CpuVideoTree.Items.Add(TmpCheckBox);
            }
        }

        private void AddBoxInMotherBProducerTree()
        {

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

        private void CheckCpu(object sender, RoutedEventArgs e)
        {

            string producer = string.Empty;
            string core = string.Empty;
            string socket = string.Empty;
            string video = string.Empty;

            foreach (var item in CpuProducerTree.Items)
            {
                if ((item as CheckBox).IsChecked == true)
                {
                    producer += (item as CheckBox).Content;
                }
            }

            foreach (var item in CpuCoreTree.Items)
            {
                if ((item as CheckBox).IsChecked == true)
                {
                    core += (item as CheckBox).Content;
                }
            }

            foreach (var item in CpuSocketTree.Items)
            {
                if ((item as CheckBox).IsChecked == true)
                {
                    socket += (item as CheckBox).Content;
                }
            }

            foreach (var item in CpuVideoTree.Items)
            {
                if ((item as CheckBox).IsChecked == true)
                {
                    video += (item as CheckBox).Content;
                }
            }

            List<BllCpu> BindingCpu = ListBllCpu.Where(x =>
                                      core.IndexOf(x.Core.ToString()) >= 0
                                      && producer.IndexOf(x.Producer) >= 0
                                      && socket.IndexOf(x.Socket)>=0
                                      && video.IndexOf(x.Video)>=0).ToList();
            CpusDataGrid.ItemsSource = BindingCpu;
        }
    }
}
