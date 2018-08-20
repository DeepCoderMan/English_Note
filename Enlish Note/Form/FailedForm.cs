using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enlish_Note.uControl;

namespace Enlish_Note
{
    public partial class FailedForm : Form
    {
        List<CsFaild> _listFailed;
        public FailedForm(List<CsFaild> listfaild)
        {
            InitializeComponent();
            _listFailed = listfaild;
        }

        private void FailedForm_Load(object sender, EventArgs e)
        {
            foreach (var temp in _listFailed)
            {
                textBox1.Text += string.Format("{0}: {1} >> {2} ,Answer:{3} \r\n \r\n", 
                    temp.NG_Word.Date, temp.NG_Word.English, temp.NG_Word.Chinese, temp.NG_Answer);
            }
        }

        private void FailedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
