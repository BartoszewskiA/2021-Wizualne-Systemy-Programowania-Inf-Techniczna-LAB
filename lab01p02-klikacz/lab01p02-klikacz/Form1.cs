using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01p02_klikacz
{
    public partial class Form1 : Form
    {
        public int liczbaKlikniec = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liczbaKlikniec++;
            kolor();
            label1.Text = liczbaKlikniec.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            liczbaKlikniec--;
            kolor();
            label1.Text = liczbaKlikniec.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            liczbaKlikniec = 0;
            kolor();
            label1.Text = liczbaKlikniec.ToString();
        }

        private void kolor()
        {
            if (liczbaKlikniec > 0)
                label1.ForeColor = Color.FromArgb(0,20,200,30);
            else if (liczbaKlikniec == 0)
                label1.ForeColor = Color.Black;
            else
                label1.ForeColor = Color.Red;
        }
    }
}
