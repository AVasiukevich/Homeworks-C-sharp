using MailDispatch.MyForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MailDispatch
{
    public partial class MainForm : Form
    {
        bool searchEvent;
        string selectNames;
        string selectEmails;
        List<TreeUsers> listMyNodes;
        BindingList<DataEvent> dataEvents;
        BindingList<string> events;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Methods
        private void MainForm_Load(object sender, EventArgs e)
        {
            MyTimer.Start();
            cmb_server.DataSource = new List<string>() { "Mail", "Yandex", "Gmail" };
            events = new BindingList<string>() { "День Рождения",
                                                 "Новый Год",
                                                 "Рождество",
                                                 "День Танкиста",
                                                 "День программиста"
            };
            cb_events.DataSource = events;
            dataEvents = new BindingList<DataEvent>();
            listMyNodes = new List<TreeUsers>();
            Repository.LoadXML(ref listMyNodes);
            LoadNodes(trV_main.Nodes[0]);
        }
        private void tvMain_MouseClick(object sender, MouseEventArgs e)
        {
            var selNode = trV_main.GetNodeAt(e.X, e.Y);
            trV_main.SelectedNode = selNode; // для правой кнопки
            if (e.Button == MouseButtons.Left && selNode != null)
            {
                selectEmails = String.Empty;
                selectNames = String.Empty;
                tb_whom.Text = GetAllNames(selNode);
                tb_emails.Text = GetAllEmails(selNode);
            }
            else
                return;
        }
        private void cM_add_Click(object sender, EventArgs e)
        {
            AddForm newForm = new AddForm();
            if (newForm.ShowDialog(this) == DialogResult.OK)
            {
                var selNode = trV_main.SelectedNode;
                if (selNode != null)
                {
                    newForm.NewUser.ContextMenuStrip = cM_edit_delete;
                    selNode?.Nodes.Add(newForm.NewUser);
                }
            }
        }
        private void cM_edit_Click(object sender, EventArgs e)
        {
            AddForm newForm = new AddForm((MyNodes)trV_main.SelectedNode);
            newForm.ShowDialog();
        }
        private void cM_delete_Click(object sender, EventArgs e)
        {
            trV_main.Nodes.Remove(trV_main.SelectedNode);
        }
        /// <summary>
        /// Метод для выборки имен
        /// </summary>
        /// <param name="names">Узел дерева</param>
        /// <returns></returns>
        private string GetAllNames(TreeNode names)
        {
            if (names.Nodes.Count == 0 && trV_main.SelectedNode.Level >= 3)
                selectNames = trV_main.SelectedNode.Text + ";";

            for (int i = 0; i < names.Nodes.Count; i++)
            {
                GetAllNames(names.Nodes[i]);
                if (names.Nodes[i].Level >= 3)
                    selectNames += names.Nodes[i].Text + ";";
            }
            return selectNames;
        }
        /// <summary>
        /// Метод для выборки emails
        /// </summary>
        /// <param name="names">Узел дерева</param>
        /// <returns></returns>
        private string GetAllEmails(TreeNode names)
        {
            if (names.Nodes.Count == 0 && trV_main.SelectedNode.Level >= 3)
                selectEmails = ((MyNodes)trV_main.SelectedNode).Email + ";";

            for (int i = 0; i < names.Nodes.Count; i++)
            {
                GetAllEmails(names.Nodes[i]);
                if (names.Nodes[i].Level >= 3)
                    selectEmails += ((MyNodes)names.Nodes[i]).Email + ";";
            }
            return selectEmails;
        }
        /// <summary>
        /// Метод для загрузки из файла в дерево пользователей
        /// </summary>
        /// <param name="names">Узел дерева</param>
        /// <returns></returns>
        private void LoadNodes(TreeNode names)
        {
            for (int i = 0; i < names.Nodes.Count; i++)
            {
                LoadNodes(names.Nodes[i]);
                for (int j = 0; j < listMyNodes.Count; j++)
                {
                    if (names.Nodes[i].Text.Equals(listMyNodes[j].Parent))
                        names.Nodes[i].Nodes.Add(new MyNodes()
                        {
                            Text = listMyNodes[j].Name,
                            Email = listMyNodes[j].Email,
                            ImageIndex = listMyNodes[j].IndexImage,
                            SelectedImageIndex = listMyNodes[j].IndexImage,
                            ContextMenuStrip = cM_edit_delete
                        });
                }
            }
        }
        /// <summary>
        /// Метод для сохранения в файла из дерева пользователей
        /// </summary>
        /// <param name="names">Узел дерева</param>
        /// <returns></returns>
        private void SaveNodes(TreeNode names)
        {
            for (int i = 0; i < names.Nodes.Count; i++)
            {
                SaveNodes(names.Nodes[i]);
                if (names.Nodes[i].Level >= 3)
                    listMyNodes.Add(new TreeUsers()
                    {
                        Name = names.Nodes[i].Text,
                        Email = ((MyNodes)names.Nodes[i]).Email,
                        IndexImage = names.Nodes[i].ImageIndex,
                        Parent = names.Nodes[i].Parent.Text
                    });
            }
        }
        private void ts_btn_save_Click(object sender, EventArgs e)
        {
            Repository.SaveXML(listMyNodes);
        }
        private void ts_btn_open_Click(object sender, EventArgs e)
        {
            Repository.LoadXML(ref listMyNodes);
        }
        private void MainMenu_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Никогда ни от кого ничего не жди\nВедь слишком часто ожидания излишни\nЛишь только на себя надейся в этой жизни\nИ будет меньше сожалений впереди…", "Помощь :)");
        }
        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            tb_comments.Text = String.Empty;
            tb_text_mail.Text = String.Empty;
            num_hour.Value = 0;
            num_minutes.Value = 0;
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            dataEvents.Add(new DataEvent()
            {
                Names = tb_whom.Text,
                NameEvent = cb_events.SelectedItem.ToString(),
                Data = new DateTime(mC_main.SelectionStart.Year, mC_main.SelectionStart.Month,
                                    mC_main.SelectionStart.Day, (int)num_hour.Value, (int)num_minutes.Value, 0),
                Comments = tb_comments.Text,
                Text = tb_text_mail.Text,
                Emails = tb_emails.Text
            });
            dataGV_main.DataSource = dataEvents;
            searchEvent = true;
        }
        private void cmb_server_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_server.SelectedItem.ToString().Equals("Yandex"))
            {
                tb_address.Text = "smtp.yandex.ru";
                tb_port.Text = "25";
            }
            else if (cmb_server.SelectedItem.ToString().Equals("Gmail"))
            {
                tb_address.Text = "smtp.gmail.com";
                tb_port.Text = "58";
            }
            else
            {
                tb_address.Text = "smtp.mail.ru";
                tb_port.Text = "25";
            }
        }
        private void bkW_Main_DoWork(object sender, DoWorkEventArgs e)
        {
            status_lb.Text = "Статус: Отправка сообщений...";
            SmtpClient Smtp = new SmtpClient(tb_address.Text, Convert.ToInt32(tb_port.Text));
            Smtp.Credentials = new NetworkCredential(tb_account.Text, tb_password.Text);
            Smtp.EnableSsl = chb_SSL.Checked;
            string[] arrEmail = tb_emails.Text.Split(';');
            MailMessage message = new MailMessage();
            message.From = new MailAddress(tb_account.Text);
            for (int i = 0; i < arrEmail.Length; i++)
            {
                if (!string.IsNullOrEmpty(arrEmail[i]))
                    message.To.Add(new MailAddress(arrEmail[i]));
            }
            message.Subject = "Заголовок!";
            message.Body = tb_text_mail.Text;
            Smtp.Send(message);
            status_lb.Text = "Статус: Бездействия...";
        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (searchEvent)
            {
                BackgroundWorker thread = new BackgroundWorker();
                thread.WorkerReportsProgress = true;
                thread.WorkerSupportsCancellation = true;
                thread.DoWork += new DoWorkEventHandler(bkW_Main_DoWork);
                thread.RunWorkerAsync();
                searchEvent = false;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            listMyNodes.Clear();
            SaveNodes(trV_main.Nodes[0]);
            Repository.SaveXML(listMyNodes);
        }
        #endregion
    }
}
