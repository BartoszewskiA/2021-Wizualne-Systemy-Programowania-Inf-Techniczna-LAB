using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            przelicz();
        }

        private void przelicz()
        {
            double dana;
            if (double.TryParse(textBox1.Text, out dana)) ;
            else
            {
                dana = 0;
                textBox1.Text = dana.ToString();
            }
            if (radioButton1.Checked)
                przelicz_dlugosci(dana);
            else if (radioButton3.Checked)
                przelicz_polePowierzchni(dana);
            else
                przelicz_objetosc(dana);
        }

        private void przelicz_objetosc(double dana)
        {
            label2.Text = (dana * Math.Pow(10,9)).ToString() + " mm3";
            label3.Text = (dana * 1000000).ToString() + " cm3";
            label4.Text = (dana * 1000).ToString() + " dm3";
        }

        private void przelicz_polePowierzchni(double dana)
        {
            label2.Text = (dana * 1000000).ToString() + " mm2";
            label3.Text = (dana * 10000).ToString() + " cm2";
            label4.Text = (dana * 100).ToString() + " dm2";
        }

        private void przelicz_dlugosci(double dana)
        {
            label2.Text = (dana * 1000).ToString() + " mm";
            label3.Text = (dana * 100).ToString() + " cm";
            label4.Text = (dana * 10).ToString() + " dm";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            przelicz();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            przelicz();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            przelicz();
        }
     }
}
