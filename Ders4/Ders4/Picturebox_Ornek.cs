using Ders4.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders4
{
    public partial class Picturebox_Ornek : Form
    {
        public Picturebox_Ornek()
        {
            InitializeComponent();
        }
        List<Bitmap> resimler = new List<Bitmap>()

        {
            Resources.armut,
            Resources.cilek,
            Resources.elma,
            Resources.karpuz,
            Resources.kivi,
            Resources.muz,
            Resources.seftali,
            Resources.visne

        };

        int cevirmeSuresi = 5000;
        int degistirmeSuresi = 100;
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            Random rnd= new Random();
            int rndSayi;

            rndSayi=rnd.Next(0, resimler.Count);
            pictureBox1.Image= resimler[rndSayi];

            rndSayi = rnd.Next(0, resimler.Count);
            pictureBox2.Image = resimler[rndSayi];

            rndSayi = rnd.Next(0, resimler.Count);
            pictureBox3.Image = resimler[rndSayi];

            if (sayac==(cevirmeSuresi/degistirmeSuresi))
            {
                timer1.Stop();
                sayac = 0;
                KontrolEt();
            }

        }

        private void KontrolEt()
        {
            if (pictureBox1.Image==pictureBox2.Image && pictureBox2.Image==pictureBox3.Image && pictureBox1.Image==pictureBox3.Image)
            {
                lblBilgi.Text = "Tebrikler Kazandınız";
                lblBilgi.ForeColor= Color.Green;
            }
            else if 
                (pictureBox1.Image==pictureBox2.Image || pictureBox1.Image==pictureBox3.Image || pictureBox2.Image==pictureBox3.Image)
            {
                lblBilgi.Text = "Amorti Kazandınız";
                lblBilgi.ForeColor = Color.Orange;
            }
            else
            {
                lblBilgi.Text = "Malesef Kaybettiniz ";
                lblBilgi.ForeColor = Color.Red;
            }
        }
    }
}
