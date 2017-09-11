namespace Mosaic.MyForm
{
    partial class FormSettingMosaic
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
            this.gb_complexity = new System.Windows.Forms.GroupBox();
            this.lb_count = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.track_setting = new System.Windows.Forms.TrackBar();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.gb_complexity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_setting)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_complexity
            // 
            this.gb_complexity.Controls.Add(this.tb_count);
            this.gb_complexity.Controls.Add(this.track_setting);
            this.gb_complexity.Controls.Add(this.lb_count);
            this.gb_complexity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_complexity.Location = new System.Drawing.Point(13, 13);
            this.gb_complexity.Name = "gb_complexity";
            this.gb_complexity.Size = new System.Drawing.Size(232, 89);
            this.gb_complexity.TabIndex = 0;
            this.gb_complexity.TabStop = false;
            this.gb_complexity.Text = "Сложность";
            // 
            // lb_count
            // 
            this.lb_count.Location = new System.Drawing.Point(7, 20);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(162, 23);
            this.lb_count.TabIndex = 0;
            this.lb_count.Text = "Кол-во прямоугольников";
            this.lb_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(33, 108);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(148, 108);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // track_setting
            // 
            this.track_setting.AutoSize = false;
            this.track_setting.Location = new System.Drawing.Point(10, 47);
            this.track_setting.Maximum = 2;
            this.track_setting.Name = "track_setting";
            this.track_setting.Size = new System.Drawing.Size(216, 35);
            this.track_setting.TabIndex = 1;
            this.track_setting.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_setting.Scroll += new System.EventHandler(this.track_setting_Scroll);
            // 
            // tb_count
            // 
            this.tb_count.Location = new System.Drawing.Point(176, 21);
            this.tb_count.Name = "tb_count";
            this.tb_count.ReadOnly = true;
            this.tb_count.Size = new System.Drawing.Size(23, 20);
            this.tb_count.TabIndex = 2;
            this.tb_count.Text = "9";
            this.tb_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormSettingMosaic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 138);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.gb_complexity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSettingMosaic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.gb_complexity.ResumeLayout(false);
            this.gb_complexity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_setting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_complexity;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TrackBar track_setting;
        private System.Windows.Forms.TextBox tb_count;
    }
}