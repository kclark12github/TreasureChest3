using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC3Model.Login
{
    public class LoginEventArgs : EventArgs
    {
        public LoginEventArgs()
        {
            LoginObject = null;
        }
        public LoginEventArgs(Login login)
        {
            LoginObject = login;
        }
        public Login LoginObject { get; set; }
    }
}
