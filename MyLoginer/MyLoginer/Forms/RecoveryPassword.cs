using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginer.Forms
{
    public partial class RecoveryPassword : Form
    {
        public RecoveryPassword()
        {
            InitializeComponent();
        }

        private void RecoveryPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.Owner).Show();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string pattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
            if (!Regex.IsMatch(tb_rec_mail.Text, pattern))
            {
                MessageBox.Show("Неправильный e-mail введен!", "Ошибка!");
                tb_rec_mail.Text = String.Empty;
            }
            else if (tb_rec_new_pass.Text.Length < 6 || !tb_rec_new_pass.Text.Equals(tb_rec_repeat_pass.Text))
            {
                MessageBox.Show("Пароли не совпадают или слишком короткие!", "Ошибка!");
                tb_rec_new_pass.Text = String.Empty;
                tb_rec_repeat_pass.Text = String.Empty;
            }
            else
            {
                foreach (User user in ((MainForm)this.Owner).ListUser)
                {
                    if (user.Mail.Equals(tb_rec_mail.Text))
                    {
                        user.Password = tb_rec_new_pass.Text;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Данного e-mail нету в базе данных!", "Ошибка!");
            }
            this.Close();
        }

        private void RecoveryPassword_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).Hide();
        }
    }
}
