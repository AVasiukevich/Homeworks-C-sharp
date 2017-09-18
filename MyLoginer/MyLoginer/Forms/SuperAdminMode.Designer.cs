namespace MyLoginer.Forms
{
    partial class SuperAdminMode
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
            this.ltb_data_base = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ltb_data_base
            // 
            this.ltb_data_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltb_data_base.FormattingEnabled = true;
            this.ltb_data_base.Location = new System.Drawing.Point(0, 0);
            this.ltb_data_base.Name = "ltb_data_base";
            this.ltb_data_base.Size = new System.Drawing.Size(466, 350);
            this.ltb_data_base.TabIndex = 0;
            // 
            // SuperAdminMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 350);
            this.Controls.Add(this.ltb_data_base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SuperAdminMode";
            this.Text = "SuperAdminMode";
            this.Load += new System.EventHandler(this.SuperAdminMode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_data_base;
    }
}