namespace Mosaic
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenu_Image = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Mix = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Return = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.pcb_main = new System.Windows.Forms.PictureBox();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_main)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_Image,
            this.MainMenu_Mix,
            this.MainMenu_Return,
            this.MainMenu_Setting,
            this.MainMenu_Help});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(600, 24);
            this.MainMenu.TabIndex = 0;
            // 
            // MainMenu_Image
            // 
            this.MainMenu_Image.Name = "MainMenu_Image";
            this.MainMenu_Image.Size = new System.Drawing.Size(70, 20);
            this.MainMenu_Image.Text = "Картинка";
            this.MainMenu_Image.Click += new System.EventHandler(this.MainMenu_Image_Click);
            // 
            // MainMenu_Mix
            // 
            this.MainMenu_Mix.Name = "MainMenu_Mix";
            this.MainMenu_Mix.Size = new System.Drawing.Size(90, 20);
            this.MainMenu_Mix.Text = "Перемешать";
            this.MainMenu_Mix.Click += new System.EventHandler(this.MainMenu_Mix_Click);
            // 
            // MainMenu_Return
            // 
            this.MainMenu_Return.Name = "MainMenu_Return";
            this.MainMenu_Return.Size = new System.Drawing.Size(94, 20);
            this.MainMenu_Return.Text = "Восстановить";
            this.MainMenu_Return.Click += new System.EventHandler(this.MainMenu_Return_Click);
            // 
            // MainMenu_Setting
            // 
            this.MainMenu_Setting.Name = "MainMenu_Setting";
            this.MainMenu_Setting.Size = new System.Drawing.Size(79, 20);
            this.MainMenu_Setting.Text = "Настройки";
            this.MainMenu_Setting.Click += new System.EventHandler(this.MainMenu_Setting_Click);
            // 
            // MainMenu_Help
            // 
            this.MainMenu_Help.Name = "MainMenu_Help";
            this.MainMenu_Help.Size = new System.Drawing.Size(68, 20);
            this.MainMenu_Help.Text = "Помощь";
            this.MainMenu_Help.Click += new System.EventHandler(this.MainMenu_Help_Click);
            // 
            // pcb_main
            // 
            this.pcb_main.Location = new System.Drawing.Point(0, 24);
            this.pcb_main.Name = "pcb_main";
            this.pcb_main.Size = new System.Drawing.Size(600, 600);
            this.pcb_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_main.TabIndex = 1;
            this.pcb_main.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 624);
            this.Controls.Add(this.pcb_main);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мозайка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Image;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Mix;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Return;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Setting;
        private System.Windows.Forms.ToolStripMenuItem MainMenu_Help;
        private System.Windows.Forms.PictureBox pcb_main;
    }
}

