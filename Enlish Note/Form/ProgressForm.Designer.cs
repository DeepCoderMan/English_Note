namespace Enlish_Note
{
    partial class ProgressForm
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
            this.Progress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Progress1
            // 
            this.Progress1.AntiAlias = false;
            // 
            // 
            // 
            this.Progress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Progress1.CausesValidation = false;
            this.Progress1.FocusCuesEnabled = false;
            this.Progress1.Font = new System.Drawing.Font("幼圆", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Progress1.Location = new System.Drawing.Point(12, 21);
            this.Progress1.Name = "Progress1";
            this.Progress1.PieBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Progress1.PieBorderLight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Progress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.Progress1.ProgressColor = System.Drawing.Color.SteelBlue;
            this.Progress1.ProgressTextColor = System.Drawing.Color.Black;
            this.Progress1.ProgressTextFormat = "{80}%";
            this.Progress1.Size = new System.Drawing.Size(244, 85);
            this.Progress1.SpokeBorderDark = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Progress1.SpokeBorderLight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Progress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.Progress1.TabIndex = 0;
            this.Progress1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(4, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "等待操作完成 . . .";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Progress1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressForm";
            this.Text = "ProgressForm";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.VisibleChanged += new System.EventHandler(this.ProgressForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CircularProgress Progress1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}