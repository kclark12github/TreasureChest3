using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC3Model.DataModel;

namespace TC3Model.Login
{
    public class Login : DataEntityBase
    {
        public Login()
        {
            try {
                Domain = Environment.UserDomainName;
                LoginID = Environment.UserName;
            }
            catch (Exception){}
        }
        #region "Properties"
        private string mDomain = string.Empty;
        private string mLoginID = string.Empty;
        private string mPassword = string.Empty;
        private bool mIsDomainVisible = false;
        private bool mRememberMe = false;
        public string Domain
        {
            get { return mDomain; }
            set { if (value != mDomain) { mDomain = value; NotifyPropertyChanged(); }; }
        }
        public string LoginID
        {
            get { return mLoginID; }
            set { if (value != mLoginID) { mLoginID = value; NotifyPropertyChanged(); }; }
        }
        public string Password
        {
            get { return mPassword; }
            set { if (value != mPassword) { mPassword = value; NotifyPropertyChanged(); }; }
        }
        public bool IsDomainVisible
        {
            get { return mIsDomainVisible; }
            set { if (value != mIsDomainVisible) { mIsDomainVisible = value; NotifyPropertyChanged(); }; }
        }
        public bool RememberMe
        {
            get { return mRememberMe; }
            set { if (value != mRememberMe) { mRememberMe = value; NotifyPropertyChanged(); }; }
        }
        #endregion
        #region "Methods"
        public void Clear()
        {
            base.ClearValidationMessages();
            Domain = string.Empty;
            LoginID = string.Empty;
            Password = string.Empty;
            IsDomainVisible = false;
            RememberMe = false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"LoginID: {mLoginID}");
            sb.AppendLine($"Password: {mPassword}");
            sb.AppendLine($"Domain: {mDomain}");
            return sb.ToString();
        }
        public override bool Validate()
        {
            base.ClearValidationMessages();
            if (String.IsNullOrEmpty(mLoginID)) 
                base.AddValidationRuleMessage("LoginID", "Login ID must be provided!");
            if (String.IsNullOrEmpty(mPassword))
                base.AddValidationRuleMessage("Password", "Password must be provided!");
            if (mIsDomainVisible && String.IsNullOrEmpty(mDomain))
                base.AddValidationRuleMessage("Domain", "Domain must be provided!");
            return (base.ValidationRuleMessages.Count == 0);
        }
    #endregion
    }
}
