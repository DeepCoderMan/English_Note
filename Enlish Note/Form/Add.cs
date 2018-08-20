using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enlish_Note
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CsCore.Instal.SeachWordOfChinese(textBox1.Text) != null)
            {
                MessageBox.Show("添加失败,中文项已存在");
                return;
            }
            if (CsCore.Instal.SeachWordOfEnglish(textBox2.Text) != null)
            {
                MessageBox.Show("添加失败,英文项已存在");
                return;
            }
            CsCore.Instal.AddWord(textBox2.Text,textBox1.Text);
            if (checkBox1.Checked)
            {
                this.Close();
            }
        }
    }
}
