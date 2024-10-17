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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        int saniye = 0, dakika = 0, saat = 0, tur = 0;

        private void btnTur_Click(object sender, EventArgs e)
        {
            tur++;
            listBox1.Items.Add(string.Format("{0}.Tur: {1} : {2} :{3}",tur, saat, dakika, saniye));
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saniye = 0;
            dakika = 0;
            saat = 0;
            listBox1.Items.Clear();
            label1.Text = string.Format("{0} : {1} : {2}", saat, dakika, saniye);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye==60)
            {
                dakika++;
                saniye= 0;
            }
            if (dakika==60)
            {
                saat++;
                dakika= 0;
            }
            label1.Text = string.Format("{0} : {1} : {2}",saat,dakika,saniye);
        }
    }
}
