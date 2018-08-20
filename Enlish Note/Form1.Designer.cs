namespace Enlish_Note
{
    partial class 英语词汇记录
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.添加日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.中文 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.英文 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.搜索计数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.考核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有道词典ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.从数据库加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传到数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.重新连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DB_Status = new System.Windows.Forms.Label();
            this.Progress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.添加日期,
            this.中文,
            this.英文,
            this.搜索计数,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(1, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(586, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // 添加日期
            // 
            this.添加日期.HeaderText = "添加日期";
            this.添加日期.Name = "添加日期";
            this.添加日期.ToolTipText = "添加日期";
            this.添加日期.Width = 145;
            // 
            // 中文
            // 
            this.中文.HeaderText = "中文";
            this.中文.Name = "中文";
            this.中文.Width = 135;
            // 
            // 英文
            // 
            this.英文.HeaderText = "英文";
            this.英文.Name = "英文";
            this.英文.Width = 135;
            // 
            // 搜索计数
            // 
            this.搜索计数.HeaderText = "搜索计数";
            this.搜索计数.Name = "搜索计数";
            this.搜索计数.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "操作";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.DB_Status);
            this.panel1.Controls.Add(this.Progress1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 373);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(258, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "新增";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(179, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "行数：2";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(557, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(325, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(352, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(1, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "记录详情表：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.考核ToolStripMenuItem,
            this.有道词典ToolStripMenuItem,
            this.数据库ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 考核ToolStripMenuItem
            // 
            this.考核ToolStripMenuItem.Name = "考核ToolStripMenuItem";
            this.考核ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.考核ToolStripMenuItem.Text = "考核";
            this.考核ToolStripMenuItem.Click += new System.EventHandler(this.考核ToolStripMenuItem_Click);
            // 
            // 有道词典ToolStripMenuItem
            // 
            this.有道词典ToolStripMenuItem.Name = "有道词典ToolStripMenuItem";
            this.有道词典ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.有道词典ToolStripMenuItem.Text = "有道词典";
            this.有道词典ToolStripMenuItem.Click += new System.EventHandler(this.有道词典ToolStripMenuItem_Click);
            // 
            // 数据库ToolStripMenuItem
            // 
            this.数据库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.从数据库加载ToolStripMenuItem,
            this.上传到数据库ToolStripMenuItem,
            this.重新连接ToolStripMenuItem});
            this.数据库ToolStripMenuItem.Name = "数据库ToolStripMenuItem";
            this.数据库ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.数据库ToolStripMenuItem.Text = "数据库";
            // 
            // 从数据库加载ToolStripMenuItem
            // 
            this.从数据库加载ToolStripMenuItem.Name = "从数据库加载ToolStripMenuItem";
            this.从数据库加载ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.从数据库加载ToolStripMenuItem.Text = "从数据库加载";
            this.从数据库加载ToolStripMenuItem.Click += new System.EventHandler(this.从数据库加载ToolStripMenuItem_Click);
            // 
            // 上传到数据库ToolStripMenuItem
            // 
            this.上传到数据库ToolStripMenuItem.Name = "上传到数据库ToolStripMenuItem";
            this.上传到数据库ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.上传到数据库ToolStripMenuItem.Text = "上传到数据库";
            this.上传到数据库ToolStripMenuItem.Click += new System.EventHandler(this.上传到数据库ToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "输入：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "中",
            "英"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "中",
            "英"});
            this.comboBox1.Location = new System.Drawing.Point(543, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(39, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "英";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 411);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(461, 21);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "结果：";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "搜索";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AutoClose = false;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(84, 26);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(83, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 8;
            // 
            // 重新连接ToolStripMenuItem
            // 
            this.重新连接ToolStripMenuItem.Name = "重新连接ToolStripMenuItem";
            this.重新连接ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.重新连接ToolStripMenuItem.Text = "重新连接";
            this.重新连接ToolStripMenuItem.Click += new System.EventHandler(this.重新连接ToolStripMenuItem_Click);
            // 
            // DB_Status
            // 
            this.DB_Status.AutoSize = true;
            this.DB_Status.CausesValidation = false;
            this.DB_Status.Location = new System.Drawing.Point(557, 7);
            this.DB_Status.Name = "DB_Status";
            this.DB_Status.Size = new System.Drawing.Size(17, 12);
            this.DB_Status.TabIndex = 8;
            this.DB_Status.Text = "DB";
            // 
            // Progress1
            // 
            this.Progress1.BackColor = System.Drawing.Color.DimGray;
            // 
            // 
            // 
            this.Progress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Progress1.Enabled = false;
            this.Progress1.Location = new System.Drawing.Point(6, 40);
            this.Progress1.Name = "Progress1";
            this.Progress1.Size = new System.Drawing.Size(580, 261);
            this.Progress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.Progress1.TabIndex = 9;
            this.Progress1.Visible = false;
            this.Progress1.ValueChanged += new System.EventHandler(this.circularProgress1_ValueChanged);
            // 
            // 英语词汇记录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(589, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "英语词汇记录";
            this.Text = "英语词汇记录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.英语词汇记录_FormClosing);
            this.Load += new System.EventHandler(this.英语词汇记录_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 添加日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 中文;
        private System.Windows.Forms.DataGridViewTextBoxColumn 英文;
        private System.Windows.Forms.DataGridViewTextBoxColumn 搜索计数;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 考核ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 有道词典ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 从数据库加载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传到数据库ToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem 重新连接ToolStripMenuItem;
        private System.Windows.Forms.Label DB_Status;
        private DevComponents.DotNetBar.Controls.CircularProgress Progress1;
    }
}

