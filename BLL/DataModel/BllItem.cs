using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.ComponentModel;
using System.IO;
using System.Net.Cache;
using System.Windows.Markup;
using System.Windows.Media.Imaging;


namespace BLL.DataModel
{
    public class BllItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Producer { get; set; }
        public string Provider { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalaryPrice { get; set; }
        public BitmapImage Image { get; set; }
        
    }
}
