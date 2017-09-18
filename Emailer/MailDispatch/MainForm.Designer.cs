namespace MailDispatch
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Близкие родственники", 13, 13);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Дальные родственники", 14, 14);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Родственники", 9, 9, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("из Офиса", 15, 15);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Другие", 12, 12);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Коллеги", 17, 17, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Близкие друзья", 19, 19);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Знакомые", 18, 18);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Друзья", 16, 16, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Получатели", 10, 10, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            this.cM_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cM_add = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_File_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.status_main = new System.Windows.Forms.StatusStrip();
            this.status_lb = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts_main = new System.Windows.Forms.ToolStrip();
            this.ts_btn_save = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_open = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_help = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trV_main = new System.Windows.Forms.TreeView();
            this.imglist_main = new System.Windows.Forms.ImageList(this.components);
            this.tbc_total = new System.Windows.Forms.TabControl();
            this.tbp_main = new System.Windows.Forms.TabPage();
            this.btn_clear_all = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.tb_text_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_comments = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num_minutes = new System.Windows.Forms.NumericUpDown();
            this.num_hour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_events = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mC_main = new System.Windows.Forms.MonthCalendar();
            this.tb_emails = new System.Windows.Forms.TextBox();
            this.tb_whom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbP_result = new System.Windows.Forms.TabPage();
            this.dataGV_main = new System.Windows.Forms.DataGridView();
            this.tbc_setting = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_SSL = new System.Windows.Forms.CheckBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_account = new System.Windows.Forms.TextBox();
            this.cmb_server = new System.Windows.Forms.ComboBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.cM_edit_delete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cM_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cM_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cM_main.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.status_main.SuspendLayout();
            this.ts_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbc_total.SuspendLayout();
            this.tbp_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hour)).BeginInit();
            this.tbP_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_main)).BeginInit();
            this.tbc_setting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cM_edit_delete.SuspendLayout();
            this.SuspendLayout();
            // 
            // cM_main
            // 
            this.cM_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cM_add});
            this.cM_main.Name = "contextMenuStrip1";
            this.cM_main.Size = new System.Drawing.Size(127, 26);
            // 
            // cM_add
            // 
            this.cM_add.Name = "cM_add";
            this.cM_add.Size = new System.Drawing.Size(126, 22);
            this.cM_add.Text = "Добавить";
            this.cM_add.Click += new System.EventHandler(this.cM_add_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_File,
            this.MainMenu_Help});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(804, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MainMenu_File
            // 
            this.MainMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_File_Save,
            this.MainMenu_File_Load});
            this.MainMenu_File.Name = "MainMenu_File";
            this.MainMenu_File.Size = new System.Drawing.Size(48, 20);
            this.MainMenu_File.Text = "Файл";
            // 
            // MainMenu_File_Save
            // 
            this.MainMenu_File_Save.Name = "MainMenu_File_Save";
            this.MainMenu_File_Save.Size = new System.Drawing.Size(132, 22);
            this.MainMenu_File_Save.Text = "Сохранить";
            this.MainMenu_File_Save.Click += new System.EventHandler(this.ts_btn_save_Click);
            // 
            // MainMenu_File_Load
            // 
            this.MainMenu_File_Load.Name = "MainMenu_File_Load";
            this.MainMenu_File_Load.Size = new System.Drawing.Size(132, 22);
            this.MainMenu_File_Load.Text = "Загрузить";
            this.MainMenu_File_Load.Click += new System.EventHandler(this.ts_btn_open_Click);
            // 
            // MainMenu_Help
            // 
            this.MainMenu_Help.Name = "MainMenu_Help";
            this.MainMenu_Help.Size = new System.Drawing.Size(68, 20);
            this.MainMenu_Help.Text = "Помощь";
            this.MainMenu_Help.Click += new System.EventHandler(this.MainMenu_Help_Click);
            // 
            // status_main
            // 
            this.status_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lb});
            this.status_main.Location = new System.Drawing.Point(0, 558);
            this.status_main.Name = "status_main";
            this.status_main.Size = new System.Drawing.Size(804, 22);
            this.status_main.TabIndex = 1;
            this.status_main.Text = "statusStrip1";
            // 
            // status_lb
            // 
            this.status_lb.AutoSize = false;
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(666, 17);
            this.status_lb.Text = "Статус: Бездействие...";
            this.status_lb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ts_main
            // 
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_save,
            this.ts_btn_open,
            this.ts_btn_help});
            this.ts_main.Location = new System.Drawing.Point(0, 24);
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(804, 25);
            this.ts_main.TabIndex = 4;
            this.ts_main.Text = "toolStrip1";
            // 
            // ts_btn_save
            // 
            this.ts_btn_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_save.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_save.Image")));
            this.ts_btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_save.Name = "ts_btn_save";
            this.ts_btn_save.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_save.Text = "Сохранить";
            this.ts_btn_save.Click += new System.EventHandler(this.ts_btn_save_Click);
            // 
            // ts_btn_open
            // 
            this.ts_btn_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_open.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_open.Image")));
            this.ts_btn_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_open.Name = "ts_btn_open";
            this.ts_btn_open.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_open.Text = "Открыть файл";
            this.ts_btn_open.Click += new System.EventHandler(this.ts_btn_open_Click);
            // 
            // ts_btn_help
            // 
            this.ts_btn_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_help.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_help.Image")));
            this.ts_btn_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_help.Name = "ts_btn_help";
            this.ts_btn_help.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_help.Text = "Помощь";
            this.ts_btn_help.Click += new System.EventHandler(this.MainMenu_Help_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trV_main);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbc_total);
            this.splitContainer1.Size = new System.Drawing.Size(804, 509);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 5;
            // 
            // trV_main
            // 
            this.trV_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trV_main.ImageIndex = 0;
            this.trV_main.ImageList = this.imglist_main;
            this.trV_main.Location = new System.Drawing.Point(0, 0);
            this.trV_main.Name = "trV_main";
            treeNode1.ContextMenuStrip = this.cM_main;
            treeNode1.ImageIndex = 13;
            treeNode1.Name = "Node_relatives_close";
            treeNode1.SelectedImageIndex = 13;
            treeNode1.Text = "Близкие родственники";
            treeNode2.ContextMenuStrip = this.cM_main;
            treeNode2.ImageIndex = 14;
            treeNode2.Name = "Node_relatives_distant";
            treeNode2.SelectedImageIndex = 14;
            treeNode2.Text = "Дальные родственники";
            treeNode3.ImageIndex = 9;
            treeNode3.Name = "Node_relatives";
            treeNode3.SelectedImageIndex = 9;
            treeNode3.Text = "Родственники";
            treeNode4.ContextMenuStrip = this.cM_main;
            treeNode4.ImageIndex = 15;
            treeNode4.Name = "Node_Colleagues_office";
            treeNode4.SelectedImageIndex = 15;
            treeNode4.Text = "из Офиса";
            treeNode5.ContextMenuStrip = this.cM_main;
            treeNode5.ImageIndex = 12;
            treeNode5.Name = "Node_Colleagues_Others";
            treeNode5.SelectedImageIndex = 12;
            treeNode5.Text = "Другие";
            treeNode6.ImageIndex = 17;
            treeNode6.Name = "Node_Colleagues";
            treeNode6.SelectedImageIndex = 17;
            treeNode6.Text = "Коллеги";
            treeNode7.ContextMenuStrip = this.cM_main;
            treeNode7.ImageIndex = 19;
            treeNode7.Name = "Node_Friends_Close";
            treeNode7.SelectedImageIndex = 19;
            treeNode7.Text = "Близкие друзья";
            treeNode8.ContextMenuStrip = this.cM_main;
            treeNode8.ImageIndex = 18;
            treeNode8.Name = "Node_Kith";
            treeNode8.SelectedImageIndex = 18;
            treeNode8.Text = "Знакомые";
            treeNode9.ImageIndex = 16;
            treeNode9.Name = "Node_Friends";
            treeNode9.SelectedImageIndex = 16;
            treeNode9.Text = "Друзья";
            treeNode10.ImageIndex = 10;
            treeNode10.Name = "Node_root";
            treeNode10.SelectedImageIndex = 10;
            treeNode10.Text = "Получатели";
            this.trV_main.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.trV_main.SelectedImageIndex = 0;
            this.trV_main.Size = new System.Drawing.Size(287, 509);
            this.trV_main.TabIndex = 0;
            this.trV_main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvMain_MouseClick);
            // 
            // imglist_main
            // 
            this.imglist_main.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist_main.ImageStream")));
            this.imglist_main.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist_main.Images.SetKeyName(0, "males_male_avatar_man_people_faces_18380.png");
            this.imglist_main.Images.SetKeyName(1, "females_female_avatar_woman_people_faces_18384.png");
            this.imglist_main.Images.SetKeyName(2, "males_male_avatar_man_people_faces_18318.png");
            this.imglist_main.Images.SetKeyName(3, "females_female_avatar_woman_people_faces_18389.png");
            this.imglist_main.Images.SetKeyName(4, "males_male_avatar_man_people_faces_18341.png");
            this.imglist_main.Images.SetKeyName(5, "females_female_avatar_woman_people_faces_18406.png");
            this.imglist_main.Images.SetKeyName(6, "males_male_avatar_man_people_faces_18340.png");
            this.imglist_main.Images.SetKeyName(7, "females_female_avatar_woman_people_faces_18403.png");
            this.imglist_main.Images.SetKeyName(8, "males_male_avatar_man_people_faces_18350.png");
            this.imglist_main.Images.SetKeyName(9, "1-1.png");
            this.imglist_main.Images.SetKeyName(10, "1.png");
            this.imglist_main.Images.SetKeyName(11, "man1-256_24796.png");
            this.imglist_main.Images.SetKeyName(12, "1-2.png");
            this.imglist_main.Images.SetKeyName(13, "1-3.png");
            this.imglist_main.Images.SetKeyName(14, "1-4.png");
            this.imglist_main.Images.SetKeyName(15, "1-5.png");
            this.imglist_main.Images.SetKeyName(16, "1-6.png");
            this.imglist_main.Images.SetKeyName(17, "1-7.png");
            this.imglist_main.Images.SetKeyName(18, "1-8.png");
            this.imglist_main.Images.SetKeyName(19, "1-9.png");
            // 
            // tbc_total
            // 
            this.tbc_total.Controls.Add(this.tbp_main);
            this.tbc_total.Controls.Add(this.tbP_result);
            this.tbc_total.Controls.Add(this.tbc_setting);
            this.tbc_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_total.Location = new System.Drawing.Point(0, 0);
            this.tbc_total.Name = "tbc_total";
            this.tbc_total.SelectedIndex = 0;
            this.tbc_total.Size = new System.Drawing.Size(513, 509);
            this.tbc_total.TabIndex = 0;
            // 
            // tbp_main
            // 
            this.tbp_main.Controls.Add(this.btn_clear_all);
            this.tbp_main.Controls.Add(this.btn_create);
            this.tbp_main.Controls.Add(this.tb_text_mail);
            this.tbp_main.Controls.Add(this.label6);
            this.tbp_main.Controls.Add(this.tb_comments);
            this.tbp_main.Controls.Add(this.label5);
            this.tbp_main.Controls.Add(this.num_minutes);
            this.tbp_main.Controls.Add(this.num_hour);
            this.tbp_main.Controls.Add(this.label3);
            this.tbp_main.Controls.Add(this.cb_events);
            this.tbp_main.Controls.Add(this.label4);
            this.tbp_main.Controls.Add(this.mC_main);
            this.tbp_main.Controls.Add(this.tb_emails);
            this.tbp_main.Controls.Add(this.tb_whom);
            this.tbp_main.Controls.Add(this.label2);
            this.tbp_main.Controls.Add(this.label1);
            this.tbp_main.Location = new System.Drawing.Point(4, 22);
            this.tbp_main.Name = "tbp_main";
            this.tbp_main.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_main.Size = new System.Drawing.Size(505, 483);
            this.tbp_main.TabIndex = 0;
            this.tbp_main.Text = "Главная";
            this.tbp_main.UseVisualStyleBackColor = true;
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.Location = new System.Drawing.Point(10, 447);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(107, 23);
            this.btn_clear_all.TabIndex = 18;
            this.btn_clear_all.Text = "Сбросить Все";
            this.btn_clear_all.UseVisualStyleBackColor = true;
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // btn_create
            // 
            this.btn_create.CausesValidation = false;
            this.btn_create.Location = new System.Drawing.Point(391, 447);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(107, 23);
            this.btn_create.TabIndex = 16;
            this.btn_create.Text = "Создать";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // tb_text_mail
            // 
            this.tb_text_mail.Location = new System.Drawing.Point(10, 343);
            this.tb_text_mail.Multiline = true;
            this.tb_text_mail.Name = "tb_text_mail";
            this.tb_text_mail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_text_mail.Size = new System.Drawing.Size(488, 97);
            this.tb_text_mail.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(7, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(491, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Текст сообщения";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_comments
            // 
            this.tb_comments.Location = new System.Drawing.Point(186, 279);
            this.tb_comments.Multiline = true;
            this.tb_comments.Name = "tb_comments";
            this.tb_comments.Size = new System.Drawing.Size(312, 34);
            this.tb_comments.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(183, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Комментарий";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_minutes
            // 
            this.num_minutes.Location = new System.Drawing.Point(233, 228);
            this.num_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_minutes.Name = "num_minutes";
            this.num_minutes.Size = new System.Drawing.Size(41, 20);
            this.num_minutes.TabIndex = 11;
            // 
            // num_hour
            // 
            this.num_hour.Location = new System.Drawing.Point(186, 229);
            this.num_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.num_hour.Name = "num_hour";
            this.num_hour.Size = new System.Drawing.Size(41, 20);
            this.num_hour.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(183, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Время отправления";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_events
            // 
            this.cb_events.FormattingEnabled = true;
            this.cb_events.Location = new System.Drawing.Point(186, 178);
            this.cb_events.Name = "cb_events";
            this.cb_events.Size = new System.Drawing.Size(312, 21);
            this.cb_events.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(185, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Событие";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mC_main
            // 
            this.mC_main.Location = new System.Drawing.Point(9, 151);
            this.mC_main.Name = "mC_main";
            this.mC_main.TabIndex = 5;
            // 
            // tb_emails
            // 
            this.tb_emails.Location = new System.Drawing.Point(78, 83);
            this.tb_emails.Multiline = true;
            this.tb_emails.Name = "tb_emails";
            this.tb_emails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_emails.Size = new System.Drawing.Size(420, 56);
            this.tb_emails.TabIndex = 3;
            // 
            // tb_whom
            // 
            this.tb_whom.Location = new System.Drawing.Point(78, 22);
            this.tb_whom.Multiline = true;
            this.tb_whom.Name = "tb_whom";
            this.tb_whom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_whom.Size = new System.Drawing.Size(420, 56);
            this.tb_whom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адреса";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кому";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbP_result
            // 
            this.tbP_result.Controls.Add(this.dataGV_main);
            this.tbP_result.Location = new System.Drawing.Point(4, 22);
            this.tbP_result.Name = "tbP_result";
            this.tbP_result.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_result.Size = new System.Drawing.Size(505, 483);
            this.tbP_result.TabIndex = 1;
            this.tbP_result.Text = "Результаты рассылки";
            this.tbP_result.UseVisualStyleBackColor = true;
            // 
            // dataGV_main
            // 
            this.dataGV_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGV_main.Location = new System.Drawing.Point(3, 3);
            this.dataGV_main.Name = "dataGV_main";
            this.dataGV_main.Size = new System.Drawing.Size(499, 477);
            this.dataGV_main.TabIndex = 0;
            // 
            // tbc_setting
            // 
            this.tbc_setting.Controls.Add(this.groupBox1);
            this.tbc_setting.Location = new System.Drawing.Point(4, 22);
            this.tbc_setting.Name = "tbc_setting";
            this.tbc_setting.Padding = new System.Windows.Forms.Padding(3);
            this.tbc_setting.Size = new System.Drawing.Size(505, 483);
            this.tbc_setting.TabIndex = 2;
            this.tbc_setting.Text = "Настройки";
            this.tbc_setting.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_SSL);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.tb_account);
            this.groupBox1.Controls.Add(this.cmb_server);
            this.groupBox1.Controls.Add(this.tb_port);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки сервера SMTP";
            // 
            // chb_SSL
            // 
            this.chb_SSL.AutoSize = true;
            this.chb_SSL.Checked = true;
            this.chb_SSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_SSL.Location = new System.Drawing.Point(10, 128);
            this.chb_SSL.Name = "chb_SSL";
            this.chb_SSL.Size = new System.Drawing.Size(105, 17);
            this.chb_SSL.TabIndex = 10;
            this.chb_SSL.Text = "Включение SSL";
            this.chb_SSL.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(71, 99);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(242, 20);
            this.tb_password.TabIndex = 9;
            this.tb_password.Text = "ivan123456789";
            // 
            // tb_account
            // 
            this.tb_account.Location = new System.Drawing.Point(71, 73);
            this.tb_account.Name = "tb_account";
            this.tb_account.Size = new System.Drawing.Size(242, 20);
            this.tb_account.TabIndex = 8;
            this.tb_account.Text = "ivanitstep@mail.ru";
            // 
            // cmb_server
            // 
            this.cmb_server.FormattingEnabled = true;
            this.cmb_server.Location = new System.Drawing.Point(71, 16);
            this.cmb_server.Name = "cmb_server";
            this.cmb_server.Size = new System.Drawing.Size(121, 21);
            this.cmb_server.TabIndex = 7;
            this.cmb_server.SelectedIndexChanged += new System.EventHandler(this.cmb_server_SelectedIndexChanged);
            // 
            // tb_port
            // 
            this.tb_port.Enabled = false;
            this.tb_port.Location = new System.Drawing.Point(213, 43);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 20);
            this.tb_port.TabIndex = 6;
            this.tb_port.Text = "25";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(167, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Порт";
            // 
            // tb_address
            // 
            this.tb_address.Enabled = false;
            this.tb_address.Location = new System.Drawing.Point(71, 43);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(90, 20);
            this.tb_address.TabIndex = 4;
            this.tb_address.Text = "smtp.mail.ru";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Пароль";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Аккаунт";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Адрес";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Сервер";
            // 
            // MyTimer
            // 
            this.MyTimer.Interval = 10000;
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // cM_edit_delete
            // 
            this.cM_edit_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cM_edit,
            this.cM_delete});
            this.cM_edit_delete.Name = "cM_edit_delete";
            this.cM_edit_delete.Size = new System.Drawing.Size(129, 48);
            // 
            // cM_edit
            // 
            this.cM_edit.Name = "cM_edit";
            this.cM_edit.Size = new System.Drawing.Size(128, 22);
            this.cM_edit.Text = "Изменить";
            this.cM_edit.Click += new System.EventHandler(this.cM_edit_Click);
            // 
            // cM_delete
            // 
            this.cM_delete.Name = "cM_delete";
            this.cM_delete.Size = new System.Drawing.Size(128, 22);
            this.cM_delete.Text = "Удалить";
            this.cM_delete.Click += new System.EventHandler(this.cM_delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 580);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ts_main);
            this.Controls.Add(this.status_main);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Рассылка сообщений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.cM_main.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.status_main.ResumeLayout(false);
            this.status_main.PerformLayout();
            this.ts_main.ResumeLayout(false);
            this.ts_main.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tbc_total.ResumeLayout(false);
            this.tbp_main.ResumeLayout(false);
            this.tbp_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_hour)).EndInit();
            this.tbP_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_main)).EndInit();
            this.tbc_setting.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cM_edit_delete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_File;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Help;
        private System.Windows.Forms.StatusStrip status_main;
        private System.Windows.Forms.ToolStripStatusLabel status_lb;
        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trV_main;
        private System.Windows.Forms.TabControl tbc_total;
        private System.Windows.Forms.TabPage tbp_main;
        private System.Windows.Forms.TabPage tbP_result;
        private System.Windows.Forms.ToolStripButton ts_btn_save;
        private System.Windows.Forms.ToolStripButton ts_btn_open;
        private System.Windows.Forms.ToolStripButton ts_btn_help;
        private System.Windows.Forms.TabPage tbc_setting;
        private System.Windows.Forms.ImageList imglist_main;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar mC_main;
        private System.Windows.Forms.TextBox tb_emails;
        private System.Windows.Forms.TextBox tb_whom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear_all;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox tb_text_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_comments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_minutes;
        private System.Windows.Forms.NumericUpDown num_hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_events;
        private System.Windows.Forms.DataGridView dataGV_main;
        private System.Windows.Forms.ContextMenuStrip cM_main;
        private System.Windows.Forms.ToolStripMenuItem cM_add;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_File_Save;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_File_Load;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chb_SSL;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_account;
        private System.Windows.Forms.ComboBox cmb_server;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.ContextMenuStrip cM_edit_delete;
        private System.Windows.Forms.ToolStripMenuItem cM_edit;
        private System.Windows.Forms.ToolStripMenuItem cM_delete;
    }
}

