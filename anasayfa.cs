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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Atama.kategori = "Anasayfa";
            
            
            this.AutoScroll = true;
            this.MaximizeBox = false;

            
            button1.Text = "TÜRKİYE";
            button2.Text = "DÜNYA";
            button3.Text = "Kaydolun";
            button4.Text = "Giriş Yapın";

            button5.Text = "Admin Girişi";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            button2.Visible = false;
            
            dünya dunya = new dünya();
            dunya.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            button1.Visible = false;
           
            türkiye turkiye = new türkiye();
            turkiye.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            kayitsayfasi kayıt = new kayitsayfasi();
            kayıt.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            girisYapin giris = new girisYapin();
            this.Hide();
            giris.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            admingiris gec = new admingiris();
            gec.Show();
            this.Hide();
        }
    }
}
