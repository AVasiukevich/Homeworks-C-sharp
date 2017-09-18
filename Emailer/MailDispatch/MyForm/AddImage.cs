using System;
using System.Drawing;
using System.Windows.Forms;

namespace MailDispatch.MyForm
{
    public partial class AddImage : Form
    {
        private Image selectedImage;
        public Image SelectedImage
        {
            get{return selectedImage; }
        }

        public AddImage()
        {
            InitializeComponent();
        }
        private void pic_1_Click(object sender, EventArgs e)
        {
            PictureBox select = sender as PictureBox;
            if(select != null)
            {
                selectedImage = select.Image;
                selectedImage.Tag = select.Tag;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
