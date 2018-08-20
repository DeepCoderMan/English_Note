namespace Enlish_Note.uControl
{
    partial class ucExam
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.QuestionNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.CheckPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.checkBoxX1);
            this.panel1.Controls.Add(this.switchButton1);
            this.panel1.Controls.Add(this.labelX3);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.QuestionNum);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 41);
            this.panel1.TabIndex = 0;
            // 
            // switchButton1
            // 
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(375, 10);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffText = "en";
            this.switchButton1.OnText = "zh";
            this.switchButton1.Size = new System.Drawing.Size(66, 22);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 6;
            this.switchButton1.Value = true;
            this.switchButton1.ValueObject = "Y";
            this.switchButton1.ValueChanged += new System.EventHandler(this.switchButton1_ValueChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(137, 11);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(113, 23);
            this.labelX3.Symbol = "";
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "开始时长：0";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(457, 5);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 31);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "开始考核";
            this.buttonX1.TextColor = System.Drawing.Color.OrangeRed;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // QuestionNum
            // 
            this.QuestionNum.BackColor = System.Drawing.Color.DarkSeaGreen;
            // 
            // 
            // 
            this.QuestionNum.Border.Class = "TextBoxBorder";
            this.QuestionNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.QuestionNum.ForeColor = System.Drawing.Color.DimGray;
            this.QuestionNum.Location = new System.Drawing.Point(103, 11);
            this.QuestionNum.Name = "QuestionNum";
            this.QuestionNum.PreventEnterBeep = true;
            this.QuestionNum.Size = new System.Drawing.Size(29, 21);
            this.QuestionNum.TabIndex = 2;
            this.QuestionNum.Text = "10";
            this.QuestionNum.Enter += new System.EventHandler(this.QuestionNum_Enter);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 10);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(102, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX2.Symbol = "";
            this.labelX2.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "设置题数：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(533, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(103, 23);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolColor = System.Drawing.Color.Lime;
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Score: 0";
            // 
            // CheckPanel
            // 
            this.CheckPanel.AutoScroll = true;
            this.CheckPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CheckPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CheckPanel.Location = new System.Drawing.Point(1, 43);
            this.CheckPanel.Name = "CheckPanel";
            this.CheckPanel.Size = new System.Drawing.Size(650, 438);
            this.CheckPanel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(263, 10);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(110, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 7;
            this.checkBoxX1.Text = "下次开始刷新";
            this.checkBoxX1.CheckedChanged += new System.EventHandler(this.checkBoxX1_CheckedChanged);
            // 
            // ucExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.CheckPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ucExam";
            this.Size = new System.Drawing.Size(654, 484);
            this.Load += new System.EventHandler(this.ucExam_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX QuestionNum;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel CheckPanel;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
    }
}
