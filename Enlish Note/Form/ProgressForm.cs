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
    public partial class ProgressForm : Form
    {
        public bool IsHide { get; set; }

        Point p;
        public ProgressForm(Point pin)
        {
            InitializeComponent();
            p = pin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Progress1.IsRunning = true;  
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(p.X + 20, p.Y + 10);

            Progress1.IsRunning = true;
            SetTime(true);
        }

        protected override void OnShown(EventArgs e)
        { 

            base.OnShown(e);
        }

        

        void SetTime(bool b)
        {
            timer1.Enabled = b;
        }

        static bool ChangeLabel = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ChangeLabel)
            {
                ChangeLabel = false;
                label1.Text = "等待操作完成 . . . . . .";
            }
            else
            {
                ChangeLabel = true;
                label1.Text = "等待操作完成 . . .";
            }
        }

        private void ProgressForm_VisibleChanged(object sender, EventArgs e)
        {
            IsHide = this.Visible;
        }
    }
}
