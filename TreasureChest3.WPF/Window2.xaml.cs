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
using System.Xml.Linq;

namespace TreasureChest3.WPF
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            XElement DecalList = XDocument.Load(@"C:\Users\kclark\source\repos\TreasureChest3\TreasureChest3.WPF\Resources\XML\Decals.xml").Root;
            dgDecals2.ItemsSource = DecalList.Elements("Record").Select(e => new {
                    ID = Convert.ToInt32(e.Element("ID").Value),
                    Scale = e.Element("Scale").Value,
                    Manufacturer = e.Element("Manufacturer").Value,
                    Designation = e.Element("Designation").Value,
                    Name = e.Element("Name").Value,
                    Price = Convert.ToDecimal(e.Element("Price").Value),
                    Value = Convert.ToDecimal(e.Element("Value").Value),
                    DatePurchased = Convert.ToDateTime(e.Element("DatePurchased").Value),
                    WishList = Convert.ToBoolean(Convert.ToInt16(e.Element("WishList").Value))
                });
        }
    }
}
