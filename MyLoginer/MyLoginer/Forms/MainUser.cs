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
    public partial class MainUser : Form
    {
        User user;
        public MainUser(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void MainUser_Load(object sender, EventArgs e)
        {
            ltb_info.Items.Add(String.Format($"{user.FirstName} {user.LastName}"));
        }
        private void MainUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                ((MainForm)this.Owner).Close();
            }
        }

    }
}
