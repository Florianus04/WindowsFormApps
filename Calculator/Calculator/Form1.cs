using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1, sayi2;
        void SayilariAl()
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            SayilariAl();
            sonuc.Text = "Sonuç : " + (sayi1 - sayi2);
        }

        private void carp_Click(object sender, EventArgs e)
        {
            SayilariAl();
            sonuc.Text = "Sonuç : " + (sayi1 * sayi2);
        }

        private void bol_Click(object sender, EventArgs e)
        {
            SayilariAl();
            sonuc.Text = "Sonuç : " + (sayi1 / sayi2);
        }

        private void topla_Click(object sender, EventArgs e)
        {
            SayilariAl();
            sonuc.Text = "Sonuç : " + (sayi1 + sayi2);
        }
    }
}
