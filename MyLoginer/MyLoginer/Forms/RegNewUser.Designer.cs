namespace MyLoginer.Forms
{
    partial class RegNewUser
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
            this.grp_1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_password_repeat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.grp_1.SuspendLayout();
            this.grp_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_1
            // 
            this.grp_1.Controls.Add(this.label10);
            this.grp_1.Controls.Add(this.label9);
            this.grp_1.Controls.Add(this.label8);
            this.grp_1.Controls.Add(this.tb_password_repeat);
            this.grp_1.Controls.Add(this.label3);
            this.grp_1.Controls.Add(this.tb_password);
            this.grp_1.Controls.Add(this.label2);
            this.grp_1.Controls.Add(this.tb_login);
            this.grp_1.Controls.Add(this.label1);
            this.grp_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grp_1.Location = new System.Drawing.Point(12, 12);
            this.grp_1.Name = "grp_1";
            this.grp_1.Size = new System.Drawing.Size(262, 200);
            this.grp_1.TabIndex = 0;
            this.grp_1.TabStop = false;
            this.grp_1.Text = "Информация авторизации";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(229, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(229, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(229, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "*";
            // 
            // tb_password_repeat
            // 
            this.tb_password_repeat.Location = new System.Drawing.Point(6, 154);
            this.tb_password_repeat.Multiline = true;
            this.tb_password_repeat.Name = "tb_password_repeat";
            this.tb_password_repeat.Size = new System.Drawing.Size(217, 34);
            this.tb_password_repeat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Повторите пароль:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(6, 96);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(217, 34);
            this.tb_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(6, 42);
            this.tb_login.Multiline = true;
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(217, 34);
            this.tb_login.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // grp_2
            // 
            this.grp_2.Controls.Add(this.label11);
            this.grp_2.Controls.Add(this.tb_first_name);
            this.grp_2.Controls.Add(this.tb_mail);
            this.grp_2.Controls.Add(this.label6);
            this.grp_2.Controls.Add(this.label4);
            this.grp_2.Controls.Add(this.tb_last_name);
            this.grp_2.Controls.Add(this.label5);
            this.grp_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grp_2.Location = new System.Drawing.Point(316, 12);
            this.grp_2.Name = "grp_2";
            this.grp_2.Size = new System.Drawing.Size(262, 200);
            this.grp_2.TabIndex = 1;
            this.grp_2.TabStop = false;
            this.grp_2.Text = "Личные данные";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(227, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "*";
            // 
            // tb_first_name
            // 
            this.tb_first_name.Location = new System.Drawing.Point(6, 42);
            this.tb_first_name.Multiline = true;
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(215, 34);
            this.tb_first_name.TabIndex = 12;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(6, 154);
            this.tb_mail.Multiline = true;
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(215, 34);
            this.tb_mail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // tb_last_name
            // 
            this.tb_last_name.Location = new System.Drawing.Point(6, 96);
            this.tb_last_name.Multiline = true;
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(215, 34);
            this.tb_last_name.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Имя:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "* - для обязаительного заполнения";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(414, 220);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "Ок";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(495, 220);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // RegNewUser
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(590, 248);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grp_2);
            this.Controls.Add(this.grp_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegNewUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация нового пользователя";
            this.Activated += new System.EventHandler(this.RegNewUser_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegNewUser_FormClosing);
            this.grp_1.ResumeLayout(false);
            this.grp_1.PerformLayout();
            this.grp_2.ResumeLayout(false);
            this.grp_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_2;
        private System.Windows.Forms.TextBox tb_password_repeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_last_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}