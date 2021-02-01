using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _4.Sayfa
{
    public partial class girisYapin : Form
    {
       
        
        public girisYapin()
        {
            InitializeComponent();
        }
       
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pictureBox1.BackgroundImage = Properties.Resources.user_icon;
            panel1.ForeColor = Color.FromArgb(23, 32, 42);
            textBox1.ForeColor = Color.FromArgb(23, 32, 42);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            pictureBox2.BackgroundImage = Properties.Resources.lock_icon;
            panel2.ForeColor = Color.FromArgb(23, 32, 42);
            textBox2.ForeColor = Color.FromArgb(23, 32, 42);
        }


        public string mail;
        public string tel;

        
        OleDbConnection baglan= new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database5.mdb");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();

              
                OleDbCommand kaydetcmd = new OleDbCommand("SELECT * From kayitsayfasiveritabani WHERE kullaniciadi = '" + textBox1.Text + "' AND sifre = '" + textBox2.Text + "'", baglan);
               
                OleDbDataReader oku = kaydetcmd.ExecuteReader();

                if (oku.Read())
                {
                   
                    mail = oku[1].ToString();
                    tel = oku[3].ToString();
                    GırısAtama gırıs = new GırısAtama(textBox1.Text, mail, tel);
                    MessageBox.Show("Giriş başarılıdır.");
                    
                }
               
            }
            catch
            {
               
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglan.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = "checkin.png";
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label1.Text = "Tekrar Hoşgeldiniz!";

            pictureBox4.ImageLocation = "logo1.png";
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Atama.kategori == "Muze")
            {
                this.Hide();
                Muze muze = new Muze();
                muze.Show();
            }

            if (Atama.kategori == "Tur")
            {
                this.Hide();
                Tur tur = new Tur();
                tur.Show();

            }

            if (Atama.kategori == "Otel")
            {
                this.Hide();
                Otel otel = new Otel();
                otel.Show();

            }

            if (Atama.kategori == "Restoran")
            {
                this.Hide();
                Restoran rest = new Restoran();
                rest.Show();

            }

            if (Atama.kategori == "Odeme")
            {
                this.Hide();
                Odeme odeme = new Odeme();
                odeme.Show();

            }

            if (Atama.kategori == "Anasayfa")
            {
                this.Hide();
                anasayfa ana = new anasayfa();
                ana.Show();
            }
        }
    }
}

