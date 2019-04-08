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
using TC3Base;

namespace TreasureChest3.WPF
{
    /// <summary>
    /// Interaction logic for WinBooks.xaml
    /// </summary>
    public partial class WinBooks : Window
    {
        public WinBooks()
        {
            InitializeComponent();
            tcBase = FindResource("tcBase") as TCBase;
            Title = $"{tcBase.AppName} - {Title.Substring(3)}";
        }
        private TCBase tcBase = null;
    }
}
