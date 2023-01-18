using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisiOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soluzaklik1, soluzaklik2, soluzaklik3;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int genislik1 = pictureBox1.Width;
            int genislik2 = pictureBox2.Width;
            int genislik3 = pictureBox3.Width;
            int bitis = label4.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox1.Left + rastgele.Next(5, 15);

            if(pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label8.Text=("1. At Öne Geçti");
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label8.Text = ("2. At Öne Geçti");
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label8.Text = ("3. At Öne Geçti");
            }

            if (genislik1 + pictureBox1.Left >= bitis)
            {
                timer1.Enabled = false;
                label8.Text=("1. At Yarışı Kazandı");
            }
            if (genislik2 + pictureBox2.Left >= bitis)
            {
                timer1.Enabled = false;
                label8.Text = ("2. At Yarışı Kazandı");
            }
            if (genislik3 + pictureBox3.Left >= bitis)
            {
                timer1.Enabled = false;
                label8.Text = ("3. At Yarışı Kazandı");
            }
        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            soluzaklik1 = pictureBox1.Left;
            soluzaklik2 = pictureBox2.Left;
            soluzaklik3 = pictureBox3.Left;
        }
    }
}
