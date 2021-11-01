using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04p01
{
    public partial class Form1 : Form
    {
        private int dziesiateSek=0;
        private int sekundy = 0;
        private int minuty = 0;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "START";
            }               
            else
            {
                timer1.Start();
                button1.Text = "STOP";
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            dziesiateSek = 0;
            sekundy = 0;
            minuty = 0;
            textBox3.Text = dziesiateSek.ToString();
            textBox2.Text = sekundy.ToString();
            textBox1.Text = minuty.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dziesiateSek++;
            if (dziesiateSek > 9)
            {
                sekundy++;
                if (sekundy >59)
                {
                    sekundy = 0;
                    minuty++;
                }
                dziesiateSek = 0;
            }
            textBox3.Text = dziesiateSek.ToString();
            textBox2.Text = sekundy.ToString();
            textBox1.Text = minuty.ToString();
        }
    }
}
