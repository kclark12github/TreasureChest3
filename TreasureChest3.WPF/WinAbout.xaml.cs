using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for WinAbout.xaml
    /// </summary>
    public partial class WinAbout : Window
    {
        public WinAbout()
        {
            InitializeComponent();
            TCBase tcBase = FindResource("tcBase") as TCBase;
            Title = $"About {tcBase.AppName}";
            lblTitle.Text = tcBase.AppName;
            lblVersion.Text = $"Version: {tcBase.AppVersion}";
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
