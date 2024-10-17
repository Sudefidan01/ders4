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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pb=new PictureBox();
            pb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Picturebox_Ornek f=new Picturebox_Ornek();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
 
            Progressbar form =new Progressbar();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Progressbar_Ornek form=new Progressbar_Ornek();
            form.Show();
        }
    }
}
