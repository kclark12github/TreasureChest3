using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC3Model.Login;

namespace TC3ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
            LoginObject = new Login();
        }
        private Login mLoginObject = null;
        public Login LoginObject
        {
            get { return this.mLoginObject; }
            set { if (value != this.mLoginObject) { this.mLoginObject = value; NotifyPropertyChanged(); }; }
        }
        public override bool Validate()
        {
            return LoginObject.Validate();
        }
    }
}
