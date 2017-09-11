using System;
using System.Windows.Forms;

namespace Mosaic.MyForm
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }
        private void FormHelp_Load(object sender, EventArgs e)
        {
            pcb_help.ImageLocation = ((MainForm)this.Owner).MainImage;
        }
    }
}
