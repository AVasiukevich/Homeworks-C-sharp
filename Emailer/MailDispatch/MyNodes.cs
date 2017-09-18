using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace MailDispatch
{
    [Serializable]
    public class MyNodes : TreeNode
    {
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                email = value;
            }
        }
    }
}
