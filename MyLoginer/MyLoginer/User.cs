using System;

namespace MyLoginer
{
    [Serializable]
    public class User
    {
        private string login;
        private string password;
        private string firstName;
        private string lastName;
        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }           
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public override string ToString()
        {
            return String.Format($"{firstName} {lastName} {mail} {login} {password}");
        }
    }
}
