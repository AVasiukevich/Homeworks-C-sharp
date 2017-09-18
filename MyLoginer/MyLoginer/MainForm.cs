using MyLoginer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace MyLoginer
{
    public partial class MainForm : Form
    {
        MyProgressBar my_Progress;
        SuperAdminMode mode_form;
        private List<User> listUser;
        public List<User> ListUser
        {
            get{return listUser;}
        }
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            listUser = new List<User>();
            using (FileStream file = new FileStream("file.txt", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                listUser =(List<User>)binFormat.Deserialize(file);
            }
            if (mode_form != null) mode_form.Close();
            mode_form = new SuperAdminMode();
            mode_form.Show(this);
            bgw_loader.DoWork += Bgw_loader_DoWork;
        }
        /// <summary>
        /// Метод для отрисовки прогрессбара с текстом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bgw_loader_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(30);
                my_Progress.MyPaint();
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegNewUser reg_form = new RegNewUser();
            if(reg_form.ShowDialog(this) == DialogResult.OK)
            {
                if (mode_form != null) mode_form.Close();
                mode_form = new SuperAdminMode();
                mode_form.Show(this);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoveryPassword rec_form = new RecoveryPassword();
            if (rec_form.ShowDialog(this) == DialogResult.OK)
            {
                if (mode_form != null) mode_form.Close();
                mode_form = new SuperAdminMode();
                mode_form.Show(this);
            }
        }
        private void tb_login_enter_GotFocus(Object sender, EventArgs e)
        {
            if (tb_login_enter.Text.Equals("Имя пользователя"))
            {
                tb_login_enter.Text = String.Empty;
                tb_login_enter.ForeColor = Color.Black;
            }
        }
        private void tb_login_enter_LostFocus(Object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_login_enter.Text))
            {
                tb_login_enter.Text = "Имя пользователя";
                tb_login_enter.ForeColor = Color.LightGray;
            }
        }
        private void tb_password_enter_GotFocus(Object sender, EventArgs e)
        {
            if (tb_password_enter.Text.Equals("Пароль"))
            {
                tb_password_enter.Text = String.Empty;
                tb_password_enter.ForeColor = Color.Black;
            }
        }
        private void tb_password_enter_LostFocus(Object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_password_enter.Text))
            {
                tb_password_enter.Text = "Пароль";
                tb_password_enter.ForeColor = Color.LightGray;
            }
        }
        private void chb_hide_CheckedChanged(object sender, EventArgs e)
        {
            if(chb_hide.Checked)
                tb_password_enter.PasswordChar = '*';
            else
                tb_password_enter.PasswordChar = '\0';
        }
        private void btn_enter_Click(object sender, EventArgs e)
        {
            lb_error.Visible = false;
            my_Progress = new MyProgressBar();
            Controls.Add(my_Progress);
            my_Progress.Location = new System.Drawing.Point(22, 204);
            my_Progress.Name = "myProgressBar1";
            my_Progress.Size = new System.Drawing.Size(357, 22);
            if (!bgw_loader.IsBusy)
                bgw_loader.RunWorkerAsync();
            Thread.Sleep(3000);
            my_Progress.Hide();
            foreach (User user in listUser)
            {
                if (user.Login.Equals(tb_login_enter.Text) && user.Password.Equals(tb_password_enter.Text))
                {
                    MainUser user_form = new MainUser(user);
                    user_form.Show(this);
                    this.Hide();
                    return;
                }
            }
            lb_error.Visible = true;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream file = new FileStream("file.txt", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, listUser);
            }
        }
    }
}
