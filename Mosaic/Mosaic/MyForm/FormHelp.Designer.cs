namespace Mosaic.MyForm
{
    partial class FormHelp
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
            this.pcb_help = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_help)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_help
            // 
            this.pcb_help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcb_help.Location = new System.Drawing.Point(0, 0);
            this.pcb_help.Name = "pcb_help";
            this.pcb_help.Size = new System.Drawing.Size(434, 416);
            this.pcb_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_help.TabIndex = 0;
            this.pcb_help.TabStop = false;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 416);
            this.Controls.Add(this.pcb_help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помощь";
            this.Load += new System.EventHandler(this.FormHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_help)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_help;
    }
}