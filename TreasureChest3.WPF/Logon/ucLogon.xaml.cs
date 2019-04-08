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
using TC3Model.Login;
using TC3ViewModel;

namespace TreasureChest3.WPF.Logon
{
    /// <summary>
    /// Interaction logic for ucLogon.xaml
    /// </summary>
    public partial class ucLogon : UserControlSubmitCancel
    {
        public ucLogon()
        {
            InitializeComponent();
            mViewModel = this.FindResource("viewModel") as LoginViewModel;
            mViewModel.LoginObject.IsDomainVisible = true;
        }
        LoginViewModel mViewModel = null;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnCancel":
                    mViewModel.IsCanceled = true;
                    mViewModel.LoginObject.Clear();
                    OnCancel(new LoginEventArgs(mViewModel.LoginObject));
                    break;
                case "btnLogin":
                    mViewModel.IsCanceled = false;
                    mViewModel.LoginObject.Password = txtPassword.Password;
                    if (mViewModel.LoginObject.Validate())
                        OnSubmit(new LoginEventArgs(mViewModel.LoginObject));
                    else
                        OnError(new LoginEventArgs(mViewModel.LoginObject));
                    break;
                default:
                    break;
            }
        }
    }
}
