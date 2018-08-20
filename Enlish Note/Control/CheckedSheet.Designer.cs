namespace Enlish_Note
{
    partial class CheckedSheet
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResLight = new System.Windows.Forms.Panel();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.QuestionTabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ResLight);
            this.panel1.Controls.Add(this.switchButton1);
            this.panel1.Controls.Add(this.AnswerText);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 30);
            this.panel1.TabIndex = 0;
            // 
            // ResLight
            // 
            this.ResLight.BackColor = System.Drawing.Color.DarkGray;
            this.ResLight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResLight.Location = new System.Drawing.Point(598, 5);
            this.ResLight.Name = "ResLight";
            this.ResLight.Size = new System.Drawing.Size(25, 20);
            this.ResLight.TabIndex = 4;
            // 
            // switchButton1
            // 
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.balloonTip1.SetBalloonCaption(this.switchButton1, "标题");
            this.balloonTip1.SetBalloonText(this.switchButton1, "输入格式错误！");
            this.switchButton1.Location = new System.Drawing.Point(519, 4);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.Size = new System.Drawing.Size(66, 22);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 3;
            this.switchButton1.ValueChanged += new System.EventHandler(this.switchButton1_ValueChanged);
            // 
            // AnswerText
            // 
            this.AnswerText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highlighter1.SetHighlightColor(this.AnswerText, DevComponents.DotNetBar.Validator.eHighlightColor.Blue);
            this.highlighter1.SetHighlightOnFocus(this.AnswerText, true);
            this.AnswerText.Location = new System.Drawing.Point(266, 3);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(242, 23);
            this.AnswerText.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.QuestionTabel);
            this.panel3.Location = new System.Drawing.Point(67, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 25);
            this.panel3.TabIndex = 2;
            // 
            // QuestionTabel
            // 
            this.QuestionTabel.AutoSize = true;
            this.QuestionTabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionTabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QuestionTabel.Location = new System.Drawing.Point(5, 5);
            this.QuestionTabel.Name = "QuestionTabel";
            this.QuestionTabel.Size = new System.Drawing.Size(16, 16);
            this.QuestionTabel.TabIndex = 1;
            this.QuestionTabel.Text = "1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.IndexLabel);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 25);
            this.panel2.TabIndex = 1;
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.BackColor = System.Drawing.Color.Transparent;
            this.IndexLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IndexLabel.Location = new System.Drawing.Point(21, 5);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(16, 16);
            this.IndexLabel.TabIndex = 0;
            this.IndexLabel.Text = "1";
            // 
            // balloonTip1
            // 
            this.balloonTip1.Enabled = false;
            this.balloonTip1.ShowBalloonOnFocus = true;
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // CheckedSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CheckedSheet";
            this.Size = new System.Drawing.Size(638, 35);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.Panel ResLight;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.Label QuestionTabel;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    }
}
