using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyLoginer.Forms
{
    public partial class RegNewUser : Form
    {
        public RegNewUser()
        {
            InitializeComponent();
        }

        private void RegNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.Owner).Show();
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string pattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
            foreach (User user in ((MainForm)this.Owner).ListUser)
                if (user.Login.Equals(tb_login.Text))
                {
                    MessageBox.Show("Данный логин занят, используйте другой!", "Ошибка!");
                    tb_login.Text = String.Empty;
                    return;
                }

            if (String.IsNullOrEmpty(tb_login.Text) || String.IsNullOrEmpty(tb_password.Text) ||
               String.IsNullOrEmpty(tb_password_repeat.Text) || String.IsNullOrEmpty(tb_mail.Text))
            {
                MessageBox.Show("Заполните все поля с *!", "Ошибка!");
            }
            else if(tb_password.Text.Length < 6 || !tb_password.Text.Equals(tb_password_repeat.Text))
            {
                MessageBox.Show("Пароли не совпадают или слишком короткие!", "Ошибка!");
                tb_password.Text = String.Empty;
                tb_password_repeat.Text = String.Empty;
            }
            else if(!Regex.IsMatch(tb_mail.Text,pattern))
            {
                MessageBox.Show("Неправильный e-mail введен!", "Ошибка!");
                tb_mail.Text = String.Empty;
            }
            else
            {
                User user = new User();
                user.Login = tb_login.Text;
                user.Password = tb_password.Text;
                user.FirstName = tb_first_name.Text;
                user.LastName = tb_last_name.Text;
                user.Mail = tb_mail.Text;            
                ((MainForm)this.Owner).ListUser.Add(user);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RegNewUser_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).Hide();
        }
    }
}
