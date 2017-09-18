using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailDispatch
{
    class DataEvent
    {
        private string nameEvent;
        private DateTime data;
        private string comments;
        private string text;
        private string names;
        private string emails;

        public string Names
        {
            get { return names; }
            set { names = value; }
        }
        public string Emails
        {
            get { return emails; }
            set { emails = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public string NameEvent
        {
            get { return nameEvent; }
            set { nameEvent = value; }
        }
    }
}
