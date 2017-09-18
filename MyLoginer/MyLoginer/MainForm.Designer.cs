namespace MyLoginer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grp_1 = new System.Windows.Forms.GroupBox();
            this.chb_hide = new System.Windows.Forms.CheckBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.tb_password_enter = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_login_enter = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.link_recov = new System.Windows.Forms.LinkLabel();
            this.link_create_user = new System.Windows.Forms.LinkLabel();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.bgw_loader = new System.ComponentModel.BackgroundWorker();
            this.lb_error = new System.Windows.Forms.Label();
            this.grp_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_1
            // 
            this.grp_1.Controls.Add(this.chb_hide);
            this.grp_1.Controls.Add(this.btn_enter);
            this.grp_1.Controls.Add(this.tb_password_enter);
            this.grp_1.Controls.Add(this.lb_password);
            this.grp_1.Controls.Add(this.tb_login_enter);
            this.grp_1.Controls.Add(this.lb_login);
            this.grp_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grp_1.Location = new System.Drawing.Point(212, 14);
            this.grp_1.Name = "grp_1";
            this.grp_1.Size = new System.Drawing.Size(169, 181);
            this.grp_1.TabIndex = 1;
            this.grp_1.TabStop = false;
            this.grp_1.Text = "Параметры авторизации";
            // 
            // chb_hide
            // 
            this.chb_hide.AutoSize = true;
            this.chb_hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_hide.Location = new System.Drawing.Point(7, 140);
            this.chb_hide.Name = "chb_hide";
            this.chb_hide.Size = new System.Drawing.Size(61, 16);
            this.chb_hide.TabIndex = 5;
            this.chb_hide.Text = "скрыть";
            this.chb_hide.UseVisualStyleBackColor = true;
            this.chb_hide.CheckedChanged += new System.EventHandler(this.chb_hide_CheckedChanged);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(79, 142);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(84, 33);
            this.btn_enter.TabIndex = 0;
            this.btn_enter.Text = "Войти";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // tb_password_enter
            // 
            this.tb_password_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password_enter.ForeColor = System.Drawing.Color.LightGray;
            this.tb_password_enter.Location = new System.Drawing.Point(6, 105);
            this.tb_password_enter.Multiline = true;
            this.tb_password_enter.Name = "tb_password_enter";
            this.tb_password_enter.Size = new System.Drawing.Size(157, 29);
            this.tb_password_enter.TabIndex = 4;
            this.tb_password_enter.Text = "Пароль";
            this.tb_password_enter.GotFocus += new System.EventHandler(this.tb_password_enter_GotFocus);
            this.tb_password_enter.LostFocus += new System.EventHandler(this.tb_password_enter_LostFocus);
            // 
            // lb_password
            // 
            this.lb_password.Location = new System.Drawing.Point(7, 79);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(156, 23);
            this.lb_password.TabIndex = 2;
            this.lb_password.Text = "Пароль:";
            this.lb_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_login_enter
            // 
            this.tb_login_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login_enter.ForeColor = System.Drawing.Color.LightGray;
            this.tb_login_enter.Location = new System.Drawing.Point(7, 47);
            this.tb_login_enter.Multiline = true;
            this.tb_login_enter.Name = "tb_login_enter";
            this.tb_login_enter.Size = new System.Drawing.Size(156, 29);
            this.tb_login_enter.TabIndex = 3;
            this.tb_login_enter.Text = "Имя пользователя";
            this.tb_login_enter.GotFocus += new System.EventHandler(this.tb_login_enter_GotFocus);
            this.tb_login_enter.LostFocus += new System.EventHandler(this.tb_login_enter_LostFocus);
            // 
            // lb_login
            // 
            this.lb_login.Location = new System.Drawing.Point(7, 20);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(156, 23);
            this.lb_login.TabIndex = 0;
            this.lb_login.Text = "Имя пользователя:";
            this.lb_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // link_recov
            // 
            this.link_recov.AutoSize = true;
            this.link_recov.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_recov.Location = new System.Drawing.Point(21, 226);
            this.link_recov.Name = "link_recov";
            this.link_recov.Size = new System.Drawing.Size(132, 17);
            this.link_recov.TabIndex = 1;
            this.link_recov.TabStop = true;
            this.link_recov.Text = "Забыли пароль?";
            this.link_recov.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // link_create_user
            // 
            this.link_create_user.AutoSize = true;
            this.link_create_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_create_user.Location = new System.Drawing.Point(278, 226);
            this.link_create_user.Name = "link_create_user";
            this.link_create_user.Size = new System.Drawing.Size(103, 17);
            this.link_create_user.TabIndex = 2;
            this.link_create_user.TabStop = true;
            this.link_create_user.Text = "Регистрация";
            this.link_create_user.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pic_1
            // 
            this.pic_1.Image = global::MyLoginer.Properties.Resources.lockicon400;
            this.pic_1.Location = new System.Drawing.Point(24, 20);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(169, 175);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_1.TabIndex = 0;
            this.pic_1.TabStop = false;
            // 
            // lb_error
            // 
            this.lb_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_error.Location = new System.Drawing.Point(24, 202);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(357, 24);
            this.lb_error.TabIndex = 3;
            this.lb_error.Text = "Проверьте введенные данные";
            this.lb_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_error.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 246);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.pic_1);
            this.Controls.Add(this.link_create_user);
            this.Controls.Add(this.link_recov);
            this.Controls.Add(this.grp_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grp_1.ResumeLayout(false);
            this.grp_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_1;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox tb_password_enter;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_login_enter;
        private System.Windows.Forms.LinkLabel link_recov;
        private System.Windows.Forms.LinkLabel link_create_user;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.CheckBox chb_hide;
        private System.ComponentModel.BackgroundWorker bgw_loader;
        private System.Windows.Forms.Label lb_error;
    }
}

