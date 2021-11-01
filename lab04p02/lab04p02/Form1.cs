using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (e.KeyChar == 'a')
            //    progressBar1.Value = progressBar1.Value - 1;
           // if (e.KeyChar == 's')  
           //     progressBar1.Value = progressBar1.Value + 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value - 1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
              timer1.Start();
            if (e.KeyCode == Keys.Right)
                timer2.Start();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer3.Stop();
        }
    }
}
