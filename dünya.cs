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
    public partial class dünya : Form
    {
        public dünya()
        {
            InitializeComponent();
        }

        private void dünya_Load(object sender, EventArgs e)
        {

            Şehirler.tanım = "Dunya";
            this.AutoScroll = true;
            this.MaximizeBox = false;

            label1.Text = "Dünya'da En Çok Tercih Edilen Yerler:";

            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox5.ImageLocation = "logo1.png";
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;


            label2.Text = "Almanya-Neuschwanstein Şatosu";

            label3.Text = "İtalya-Kolezyum";

            label4.Text = "Trolltunga-Norveç";

            label5.Text = "Tokyo İmparatorluk Sarayı-Japonya";

            comboBox1.Text = "Ülke Seçiniz";


            
            comboBox1.Items.Add(Ulke.Almanya);
            comboBox1.Items.Add(Ulke.Arjantin);
            comboBox1.Items.Add(Ulke.Japonya);
            comboBox1.Items.Add(Ulke.Norveç);
            comboBox1.Items.Add(Ulke.İtalya);



            button2.Text = "Kataloğa Git";


            button1.Text = "Anasayfaya Dön";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == Atama.isim)
            {
                Katalog katalog = new Katalog();
                katalog.Show();
                this.Hide();
            }
            else if (button2.Text == "Kataloğa Git")
            {
                Console.WriteLine("Lütfen ülke seçiniz");
            }
      
       
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Şehirler ülke = new Şehirler();
            if (comboBox1.Text == Ulke.Almanya.ToString())
            {
                Atama.isim = comboBox1.Text;
                button2.Text = Atama.isim;

            }
            else if (comboBox1.Text == Ulke.Arjantin.ToString())
            {
                Atama.isim = comboBox1.Text;
                button2.Text = Atama.isim;
            }
            else if (comboBox1.Text == Ulke.İtalya.ToString())
            {
                Atama.isim = comboBox1.Text;
                button2.Text = Atama.isim;
            }
            else if (comboBox1.Text == Ulke.Japonya.ToString())
            {
                Atama.isim = comboBox1.Text;
                button2.Text = Atama.isim;
            }
            else if (comboBox1.Text == Ulke.Norveç.ToString())
            {
                Atama.isim = comboBox1.Text;
                button2.Text = Atama.isim;

            }

        }
    }


}
