using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{
    public partial class Katalog : Form
    {
        public Katalog()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = "Anasayfaya Dön";

            pictureBox1.ImageLocation = "logo2.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.AutoScroll = true;
            this.MaximizeBox = false;
        }

       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Muze yeni = new Muze();
            yeni.Show();
            this.Hide();

        }

        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Otel yeni = new Otel();
            yeni.Show();
            this.Hide();
        }

        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Tur yeni = new Tur();
            yeni.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Restoran yeni = new Restoran();
            yeni.Show();
            this.Hide();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ULASIM yeni = new ULASIM();
            yeni.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();

        }
    }
}
