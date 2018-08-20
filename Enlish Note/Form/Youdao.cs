using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enlish_Note
{
    public partial class Youdao : Form
    {
        YoudaoDictionary _youdao;
        public Youdao()
        {
            InitializeComponent();
        }

        private void Youdao_Load(object sender, EventArgs e)
        {
            Init();
        }

        void Init()
        {
            _youdao = new YoudaoDictionary();
            _youdao.ReceiveEvent += _youdao_ReceiveEvent;
        }

        private void _youdao_ReceiveEvent(string str)
        {
            textBox2.Text = string.Empty;
            string[] Array = Regex.Split(str, "\r\n", RegexOptions.IgnoreCase);
            int count = Array.Length;
            for (int i = 0; i < count; i++)
            {
                if (Array[i].Contains("输入值"))
                {
                    textBox2.SelectionColor = Color.RoyalBlue;

                    textBox2.AppendText(Array[i] + "\r\n");

                }
                else if (Array[i].Contains("翻译结果"))
                {
                    textBox2.SelectionColor = Color.Red;

                    textBox2.AppendText(Array[i] + "\r\n");
                }
                else
                {
                    textBox2.SelectionColor = Color.Green;

                    textBox2.AppendText(Array[i] + "\r\n");
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Regex regChina = new Regex("^[^\x00-\xFF]");
            if (regChina.IsMatch(textBox1.Text))
            {
                CsCore.Instal.AddWord(textBox3.Text, textBox1.Text);
            }
            else
            {
                CsCore.Instal.AddWord(textBox1.Text, textBox2.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //_youdao.Send(textBox1.Text);
        }

        private void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox2.SelectedText == "")
                return;
            textBox3.Text = textBox2.SelectedText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _youdao.Send(textBox1.Text);
        }

        private void textBox2_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (textBox2.SelectedText == "")
                return;
            textBox3.Text = textBox2.SelectedText;
        }
    }
}
