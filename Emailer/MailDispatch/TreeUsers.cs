using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailDispatch
{
    [Serializable]
    public class TreeUsers
    {
        private string name;
        private string email;
        private int indexImage;
        private string parent;

        public string Parent
        {
            get { return parent; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Пустая строка!");
                parent = value;
            }
        }
        public int IndexImage
        {
            get { return indexImage; }
            set { indexImage = value; }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Пустая строка!");
                email = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Пустая строка!");
                name = value;
            }
        }
    }
}
