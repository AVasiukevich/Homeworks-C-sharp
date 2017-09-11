using System;
using System.Windows.Forms;

namespace Mosaic.MyForm
{
    public partial class FormSettingMosaic : Form
    {
        public double countRectangle;
        public double CountRectangle
        {
            get { return countRectangle; }
        }
        public FormSettingMosaic()
        {
            InitializeComponent();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            countRectangle = Double.Parse(tb_count.Text);
            this.DialogResult = DialogResult.OK;
        }
        private void track_setting_Scroll(object sender, EventArgs e)
        {
            if (track_setting.Value == 1)
                tb_count.Text = "16";
            else if (track_setting.Value == 2)
                tb_count.Text = "25";
            else
                tb_count.Text = "9";
        }
    }
}
