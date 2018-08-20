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
    public partial class Defect : Form
    {
        public Defect()
        {
            InitializeComponent();
        }

        private void Defect_Load(object sender, EventArgs e)
        {
            ucExam1.Initial(CsCore.Instal.ListWord);
        }
    }
}
