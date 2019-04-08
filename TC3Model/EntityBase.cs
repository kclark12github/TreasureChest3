using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC3Model
{
    public class EntityBase : PropertyBase
    {
        #region "Validation Properties/Methods"
        private ValidationRuleMessages mValidationRuleMessages = new ValidationRuleMessages();
        public ValidationRuleMessages ValidationRuleMessages
        {
            get { return mValidationRuleMessages; }
        }
        public void AddValidationRuleMessage(string PropertyName, string Message)
        {
            mValidationRuleMessages.Add(new ValidationRuleMessage(PropertyName, Message));
        }
        public virtual bool Validate()
        {
            return true;
        }
        public void ClearValidationMessages()
        {
            mValidationRuleMessages.Clear();
        }
        #endregion
    }
}
