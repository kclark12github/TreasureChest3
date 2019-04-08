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

namespace TreasureChest3.WPF.Logon
{
    /// <summary>
    /// Interaction logic for UserControlSubmitCancel.xaml
    /// </summary>
    public class UserControlSubmitCancel : UserControl
    {
        public UserControlSubmitCancel()
        {
            //InitializeComponent();
        }
        public event CancelEventHandler Cancel;
        public delegate void CancelEventHandler(object sender, EventArgs e);
        public event SubmitEventHandler Error;
        public delegate void ErrorEventHandler(object sender, EventArgs e);
        public event SubmitEventHandler Submit;
        public delegate void SubmitEventHandler(object sender, EventArgs e);

        protected virtual void OnCancel(EventArgs e)
        {
            Cancel(this, e);
        }
        protected virtual void OnError(EventArgs e)
        {
            Error(this, e);
        }
        protected virtual void OnSubmit(EventArgs e)
        {
            Submit(this, e);
        }
    }
}
