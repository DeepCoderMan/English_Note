namespace Enlish_Note
{
    partial class Defect
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
            this.ucExam1 = new Enlish_Note.uControl.ucExam();
            this.SuspendLayout();
            // 
            // ucExam1
            // 
            this.ucExam1.AutoSize = true;
            this.ucExam1.Location = new System.Drawing.Point(2, 1);
            this.ucExam1.Name = "ucExam1";
            this.ucExam1.Size = new System.Drawing.Size(642, 484);
            this.ucExam1.TabIndex = 0;
            // 
            // Defect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(650, 484);
            this.Controls.Add(this.ucExam1);
            this.Name = "Defect";
            this.Text = "Defect";
            this.Load += new System.EventHandler(this.Defect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uControl.ucExam ucExam1;
    }
}