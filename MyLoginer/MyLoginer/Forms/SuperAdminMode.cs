using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLoginer.Forms
{
    public partial class SuperAdminMode : Form
    {
        public SuperAdminMode()
        {
            InitializeComponent();
        }
        private void SuperAdminMode_Load(object sender, EventArgs e)
        {
            foreach (User user in ((MainForm)this.Owner).ListUser)
            {
                ltb_data_base.Items.Add(user.ToString());
            }
        }
    }
}
