﻿using Ders4.Properties;
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
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Image.FromFile(dosyaYolu) => Metodu arracılığı ile doş kaynaktaki bir esmi Image formatında alıp picturbox içerisinde gösterebilirsiniz
            pictureBox1.Image = Image.FromFile(@"C:\Users\sadullah.sener\Desktop\Yeni klasör\a.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Resources dosyası içerisine kayıt edilen dosyalara Resources. diyerek ulaşım sağlayabiliriz
            pictureBox1.Image = Resources.b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ImageLocation => property si ile uzak sunucu üzerindeki resimleri projeniz içerisinde gösterebilirsiniz
            pictureBox1.ImageLocation = "https://e1.pxfuel.com/desktop-wallpaper/317/743/desktop-wallpaper-spongebob-squarepants-krabby-patty.jpg";
        }
    }
}
