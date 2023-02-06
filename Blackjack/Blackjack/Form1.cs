using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac =0;
        int oyuncuPuan, pcPuan;
        private void btnKartCek_Click(object sender, EventArgs e)
        {
            sayac += 1;
            btnOyunBitir.Enabled = true;
            if (sayac == 1)
            {
                int a1, a2, toplam;
                a1 = rastgele.Next(1, 11);
                a2 = rastgele.Next(1, 11);
                toplam = a1 + a2;
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                label10.Text = toplam.ToString();
            }
            if (sayac == 2)   
            {
                int a3,toplam;
                a3 = rastgele.Next(1, 11);
                label3.Text = a3.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label10.Text = toplam.ToString();
            }
            if (sayac == 3)
            {
                int a4, toplam;
                a4 = rastgele.Next(1, 11);
                label4.Text = a4.ToString();
                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label2.Text) + a4;
                label10.Text = toplam.ToString();
                btnKartCek.Enabled = false;
            }        
        }

        private void btnPcKartCek_Click(object sender, EventArgs e)
        {
            
        }
        void PcKart()
        {
            int b1, b2, toplam;
            b1 = rastgele.Next(1, 11);
            b2 = rastgele.Next(1, 11);
            toplam = b1 + b2;
            label5.Text = b1.ToString();
            label6.Text = b2.ToString();
            label11.Text = toplam.ToString();
            if (toplam < 16)
            {
                int b3;
                b3 = rastgele.Next(1, 11);
                label7.Text = b3.ToString();
                toplam = toplam + b3;
                label11.Text = toplam.ToString();
            }
            if (toplam < 16)
            {
                int b4;
                b4 = rastgele.Next(1, 11);
                label8.Text = b4.ToString();
                toplam = toplam + b4;
                label11.Text = toplam.ToString();
            }
            btnOyunBitir.Enabled = false;
        }
        private void btnOyunBitir_Click(object sender, EventArgs e)
        {
            PcKart();
            int oyuncuToplam,pcToplam;
            oyuncuToplam = Convert.ToInt32(label10.Text);
            pcToplam = Convert.ToInt32(label11.Text);
            if (oyuncuToplam > pcToplam && oyuncuToplam <= 21 || pcToplam>21)
            {
                oyuncuPuan += 1;
                lblOyuncuPuan.Text = oyuncuPuan.ToString();
                MessageBox.Show("Bu Turu Kullanıcı Kazandı");
            }
            if (oyuncuToplam < pcToplam && pcToplam <= 21 || oyuncuToplam>21)
            {
                pcPuan += 1;
                lblPcPuan.Text = pcPuan.ToString();
                MessageBox.Show("Bu Turu Bilgisayar Kazandı");
            }
            if (pcToplam > 21 && oyuncuPuan > 21)
            {
                MessageBox.Show("Berabere");
            }
            if(pcToplam == oyuncuPuan)
            {
                MessageBox.Show("Berabere");
            }
            if (oyuncuPuan == 5)
            {
                MessageBox.Show("Kullanıcı Oyunu Kazandı");
                Restart();
            }
            if (pcPuan == 5)
            {
                MessageBox.Show("Bilgisayar Oyunu Kazandı");
                Restart();
            }
            Temizle();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();         
            Temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOyunBitir.Enabled = false;
        }
        void Restart()
        {
            btnOyunBitir.Enabled = false;
            pcPuan = 0;
            lblPcPuan.Text = pcPuan.ToString();
            oyuncuPuan = 0;
            lblOyuncuPuan.Text = oyuncuPuan.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başlangıçta her oyuncuya 2 kart verilir.\nAmaç 21'den büyük olmama şartı ile rakipten daha yüksek sayı elde etmektir.\nEğer 21'den büyük veya rakibinizden düşük bir sayıya ulaşırsanız kaybedersiniz.\nKartlarınız düşük ise fazladan 2 kart çekebilirsiniz.\nYeterli sayıya ulaştığınızı düşünürseniz Sonraki Tur tuşu ile kartlarınızı rakibiniz ile karşılaştırın.\nİlk önce 5 puana ulaşan kazanır\nİyi oyunlar.");
        }

        void Temizle()
        {
            sayac = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            btnKartCek.Enabled = true;
        }
    }
}
