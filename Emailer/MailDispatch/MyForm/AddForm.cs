using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MailDispatch.MyForm
{
    public partial class AddForm : Form
    {

        private MyNodes newUser;
        public MyNodes NewUser
        {
            get {return newUser; }
        }
        public AddForm(MyNodes select = null)
        {
            InitializeComponent();
            if(select != null)
            {
                newUser = select;
                tb_name.Text = select.Text;
                tb_email.Text = select.Email;
            }
            else
                newUser = new MyNodes();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string pattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
            if (!Regex.IsMatch(tb_email.Text, pattern))
            {
                MessageBox.Show("Неправильный e-mail введен!", "Ошибка!");
                tb_email.Text = String.Empty;
            }
            else if (String.IsNullOrEmpty(tb_name.Text))
                MessageBox.Show("Заполните все поля!", "Ошибка!");
            else
            {
                newUser.Text = tb_name.Text;
                newUser.Email = tb_email.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
        private void pic_add_Click(object sender, EventArgs e)
        {
            AddImage form_image = new AddImage();
            if(form_image.ShowDialog() == DialogResult.OK)
            {
                pic_add.Image = form_image.SelectedImage;
                newUser.SelectedImageIndex = newUser.ImageIndex = Convert.ToInt32(form_image.SelectedImage.Tag);
            }
        }
    }
}
