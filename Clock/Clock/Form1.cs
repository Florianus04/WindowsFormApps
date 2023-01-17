using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (DateTime.Now.Hour.ToString() + " :");
            label2.Text = (DateTime.Now.Minute.ToString() + " :");
            label3.Text = DateTime.Now.Second.ToString();
            label4.Text = DateTime.Now.Day.ToString()+"."+DateTime.Now.Month.ToString()+"."+DateTime.Now.Year.ToString();
          
        }
        int salise = 0, dakika = 0, saniye = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            timer1.Enabled = true;
            timer3.Enabled = true;
            for(int i=0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void dateAnTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
        }

        private void alarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            label7.Text = salise.ToString();
            label5.Text = saniye.ToString();
            label6.Text = dakika.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            listBox1.Items.Add(dakika + "." + saniye + "." + salise);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            label10.Text = (DateTime.Now.Hour.ToString());
            label12.Text = (DateTime.Now.Minute.ToString());
            if (comboBox2.Text == label12.Text && comboBox1.Text==label10.Text)
            {
                timer3.Enabled = false;
                axWindowsMediaPlayer1.URL = "C:\\Users\\saffa\\source\\repos\\Clock\\Clock\\1.mp3";
                MessageBox.Show("Alarm Çalışıyor!!!");
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alarm Kuruldu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            timer2.Stop();
            listBox1.Items.Clear();
            salise = 0;
            saniye = 0;
            dakika = 0;
            label7.Text = salise.ToString();
            label6.Text = saniye.ToString();
            label5.Text = dakika.ToString();
        }
    }
}
