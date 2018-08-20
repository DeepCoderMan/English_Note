using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enlish_Note
{
    public partial class 英语词汇记录 : Form
    {
        public 英语词汇记录()
        {
            InitializeComponent();
        }

        private void 英语词汇记录_Load(object sender, EventArgs e)
        {
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;

            CsCore.Instal.TriggerEvent += Instal_TriggerEvent;

            dataGridView1.CellContentClick += DataGridView1_CellContentClick;

            textBox1.LostFocus += TextBox1_LostFocus;

            textBox1.GotFocus += TextBox1_GotFocus;

            UpdataGridDataView(DateTime.Now);

            CsCore.Instal.Sql.ConnetedHandle += Sql_ConnetedHandle;

            CsCore.Instal.Sql.LogEvent += Sql_LogEvent;

            CsCore.Instal.Sql.ErrorMessage += Sql_ErrorMessage;

            CsCore.Instal.Sql.ShowWait += Sql_ShowWait;

            DB_Status.BackColor = CsCore.Instal.Sql.Connected ? Color.Green : Color.Red;

            CsCore.Instal.pgForm = new ProgressForm(this.Location);
        }

        private void Sql_ShowWait(bool b)
        {
            ShowPgForm(b);
        }

        private void Sql_ConnetedHandle(bool b)
        {
            Invoke(new MethodInvoker(() =>
            {
                DB_Status.BackColor = b ? Color.Green : Color.Red;
            }));
        }

        private void Sql_ErrorMessage(string log)
        {
            Invoke(new MethodInvoker(() =>
            {
                MessageBox.Show(log, "error");
            }));
        }

        private void Sql_LogEvent(string log)
        {
            Invoke(new MethodInvoker(() =>
            {
                label5.Text = log;
            }));
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            textBox1_TextChanged(sender, e);
        }

        private void TextBox1_LostFocus(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                contextMenuStrip1.Close();
            }
        }

        /// <summary>
        /// 点击修改触发的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string chinese = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var temp = CsCore.Instal.SeachWordOfChinese(chinese);
            Change fm = new Change(temp);
            fm.ShowDialog();
        }

        /// <summary>
        /// 日期控件往前走一天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value - TimeSpan.FromDays(1);
        }

        /// <summary>
        /// 日期控件往前后一天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value + TimeSpan.FromDays(1);
        }

        /// <summary>
        /// 完成更新数据的请求
        /// </summary>
        private void Instal_TriggerEvent()
        {
            UpdataGridDataView(dateTimePicker1.Value);
        }

        /// <summary>
        /// 时间控件值变化时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdataGridDataView(dateTimePicker1.Value);
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        /// <param name="dt"></param>
        private void UpdataGridDataView(DateTime dt)
        {
            var Temp = CsCore.Instal.SeachWordOfDate(dt);
            if(Temp != null)
            {
                dataGridView1.Rows.Clear();
                foreach (var v in Temp)
                {
                    AddDataGridDataView(v);
                }
                ShowDateRows();
            }
        }

        /// <summary>
        /// 显示行数
        /// </summary>
        private void ShowDateRows()
        {
            Invoke(new MethodInvoker(() =>
            {
                var count = dataGridView1.Rows.Count;
                label2.Text = string.Format("行数：{0}", count);
            }));
        }

        /// <summary>
        /// 添加一行数据
        /// </summary>
        /// <param name="word"></param>
        private void AddDataGridDataView(Word word)
        {
            Invoke(new MethodInvoker(() =>
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell textboxcel2 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell textboxcel3 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell textboxcel4 = new DataGridViewTextBoxCell();
                textboxcell.Value = word.Date;
                textboxcel2.Value = word.Chinese;
                textboxcel3.Value = word.English;
                textboxcel4.Value = word.SearchCount;
                row.Cells.Add(textboxcell);
                row.Cells.Add(textboxcel2);
                row.Cells.Add(textboxcel3);
                row.Cells.Add(textboxcel4);
                DataGridViewLinkCell button1 = new DataGridViewLinkCell();
                button1.Value = "修改";
                
                row.Cells.Add(button1);
                dataGridView1.Rows.Add(row);
            }));
        }
        /// <summary>
        /// 打开新增数据对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add fm = new Add();
            fm.ShowDialog();
        }

        /// <summary>
        /// 关闭对话框时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 英语词汇记录_FormClosing(object sender, FormClosingEventArgs e)
        {
            CsCore.Instal.SeveSetting();
        }

        /// <summary>
        /// 搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "中")
            {
                textBox2.Text = CsCore.Instal.SeachWordOfChinese(textBox1.Text)?.English;
            }
            else
            {
                textBox2.Text = CsCore.Instal.SeachWordOfEnglish(textBox1.Text)?.Chinese;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            contextMenuStrip1.Items.Clear();
            if (comboBox1.Text == "英")
            {
                List<string> list = CsCore.Instal.MatchingEnlish(textBox1.Text);

                foreach (var v in list)
                {
                    contextMenuStrip1.Items.Add(v);
                }
                if (contextMenuStrip1.Items.Count > 0)
                {
                    contextMenuStrip1.Show(textBox1, 0, textBox1.Height);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textBox1.Text = e.ClickedItem.Text;
            contextMenuStrip1.Close();

            button3_Click(null, null);
        }

        private void 考核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Defect df = new Defect();
            df.Show();
        }

        private void 有道词典ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CsCore.Instal.YoudaoForm = new Youdao();
            CsCore.Instal.YoudaoForm.Show();
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Word wd = new Word()
            {
                English = "e",
                Chinese = "我",
                Date = DateTime.Now.ToString(),
                SearchCount = 2
            };
        }

        private void 上传到数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CsCore.Instal.Sql.UnloadToDataBase(CsCore.Instal.ListWord);
        }

        private void 从数据库加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(() =>
            {
                CsCore.Instal.ListWord = CsCore.Instal.Sql.LoadDataFromDataBase();

                CsCore.Instal.SeveSetting();
            }));
            th.IsBackground = true;
            th.Start();
        }

        private void 重新连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CsCore.Instal.Sql.reStart();
        }

        private void ShowPgForm(bool bShow)
        {
            Invoke(new MethodInvoker(() =>
            {
                if (bShow)
                {

                    Progress1.Visible = true;
                    Progress1.Enabled = true;
                    Progress1.IsRunning = true;

                }
                else
                {
                    Progress1.Visible = false;
                    Progress1.Enabled = false;
                    Progress1.IsRunning = false;
                }
            }));
        }

        private void circularProgress1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
