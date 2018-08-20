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
    public partial class Change : Form
    {
        Word _word;
        public Change(Word word)
        {
            InitializeComponent();
            _word = word;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word temp = _word;
            temp.Chinese = textBox1.Text;
            temp.English = textBox2.Text;
            temp.Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            CsCore.Instal.ChangeWord(_word, temp);
        }

        private void Change_Load(object sender, EventArgs e)
        {
            textBox1.Text = _word.Chinese;
            textBox2.Text = _word.English;
        }
    }
}
