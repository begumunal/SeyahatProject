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
    public partial class ULASIM : Form
    {

        public ULASIM()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Atama.kategori = "Ulasim"; 

            button21.Text = "Ödeme Sayfası";
            button22.Text = "Sepete Ekle";
            label2.Text = "Ücret";
            label9.Text = "Toplam Tutar";
            label11.Text = "*Seçim Zorunludur";
            label14.Text = Atama.isim;

            comboBox1.Items.Add(Ulasim_Yolu.Uçak.ToString());
            label3.Text = "250 TL";

            if (Şehirler.tanım == "Ulke")
            {
                pictureBox3.Visible = false;
                label4.Visible = false;
            }
             else if(Şehirler.tanım == "Turkiye")
            {
                pictureBox3.Visible = true;
                label4.Visible = true;
                label4.Text = "50 TL";
                comboBox1.Items.Add(Ulasim_Yolu.Otobus.ToString());
            }
            
            
            pictureBox1.ImageLocation = "globe.png";
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.BackgroundImage = Properties.Resources.uçak;
            pictureBox3.BackgroundImage = Properties.Resources.otobüs;

   
            label13.Text = GırısAtama.kullanıcı;
            if ((label13.Text != GırısAtama.kullanıcı)|| (GırısAtama.kullanıcı == "0"))
            {
                label13.Text = "Giriş Yapınız.";
                label13.ForeColor = Color.Maroon;
            }
            else
            {
                label13.Text = "HOŞGELDİN " + GırısAtama.kullanıcı;
                label13.ForeColor = Color.SeaGreen;
            }

            button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; button4.Enabled = false; button5.Enabled = false;
            button6.Enabled = false; button7.Enabled = false; button8.Enabled = false; button9.Enabled = false; button10.Enabled = false;
            button11.Enabled = false; button12.Enabled = false; button13.Enabled = false; button14.Enabled = false; button15.Enabled = false;
            button16.Enabled = false; button17.Enabled = false; button18.Enabled = false; button19.Enabled = false; button20.Enabled = false;
        }

  
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == Ulasim_Yolu.Uçak.ToString())
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add(Sefer_Ucak.İstanbul_Antalya.ToString());
                comboBox2.Items.Add(Sefer_Ucak.Nevşehir_İstanbul.ToString());
                comboBox2.Items.Add(Sefer_Ucak.Ankara_İstanbul.ToString());
                comboBox2.Items.Add(Sefer_Ucak.Bursa_İtalya.ToString());
                comboBox2.Items.Add(Sefer_Ucak.İstanbul_İtalya.ToString());
                comboBox2.Items.Add(Sefer_Ucak.Ankara_Almanya.ToString());
                comboBox2.Items.Add(Sefer_Ucak.İstanbul_Japonya.ToString());
                comboBox2.Items.Add(Sefer_Ucak.İstanbul_Norveç.ToString());
                comboBox2.Items.Add(Sefer_Ucak.İstanbul_Arjantin.ToString());
                comboBox2.Items.Add(Sefer_Ucak.Ankara_Arjantin.ToString());
            }
            else if (comboBox1.Text == Ulasim_Yolu.Otobus.ToString())
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add(Sefer_Otobus.Adana_Nevşehir.ToString());
                comboBox2.Items.Add(Sefer_Otobus.Ankara_Mardin.ToString());
                comboBox2.Items.Add(Sefer_Otobus.Antalya_Ankara.ToString());
                comboBox2.Items.Add(Sefer_Otobus.Ankara_Nevşehir.ToString());
                comboBox2.Items.Add(Sefer_Otobus.Trabzon_Mardin.ToString());
                comboBox2.Items.Add(Sefer_Otobus.İstanbul_Ankara.ToString());
                comboBox2.Items.Add(Sefer_Otobus.İstanbul_Nevşehir.ToString());
                comboBox2.Items.Add(Sefer_Otobus.İstanbul_Trabzon.ToString());


            }
        }

    
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
           if (comboBox2.Text == Sefer_Ucak.İstanbul_Antalya.ToString())
            {
                button1.Enabled = true; button1.BackColor = Color.Firebrick; button2.Enabled = false; button2.BackColor = Color.Firebrick;
                button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick;
                button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White;
                button14.Enabled = false; button14.BackColor = Color.Firebrick; button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick;
                button17.Enabled = false; button17.BackColor = Color.Firebrick; button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = true; button1.BackColor = Color.White; button20.Enabled = false; button20.BackColor = Color.Firebrick;
            }
           else  if (comboBox2.Text == Sefer_Ucak.İstanbul_Norveç.ToString())
            {
                button1.Enabled = true; button1.BackColor = Color.Firebrick; button2.Enabled = false; button2.BackColor = Color.Firebrick;
                button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick;
                button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White;
                button14.Enabled = false; button14.BackColor = Color.Firebrick; button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick;
                button17.Enabled = false; button17.BackColor = Color.Firebrick; button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = true; button1.BackColor = Color.White; button20.Enabled = false; button20.BackColor = Color.Firebrick;
            }

            else if (comboBox2.Text == Sefer_Ucak.Nevşehir_İstanbul.ToString())
            {
                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = false; button2.BackColor = Color.Firebrick; button3.Enabled = false; button3.BackColor = Color.Firebrick;
                button4.Enabled = false; button4.BackColor = Color.Firebrick; button5.Enabled = false; button5.BackColor = Color.Firebrick;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick;
                button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White;
                button14.Enabled = false; button14.BackColor = Color.Firebrick; button15.Enabled = true; button15.BackColor = Color.White;
                button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick;
                button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = true; button19.BackColor = Color.White; button20.Enabled = false; button20.BackColor = Color.Firebrick;

            }
           else  if (comboBox2.Text == Sefer_Ucak.Ankara_İstanbul.ToString())
            {
                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = true; button3.BackColor = Color.White; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = false; button7.BackColor = Color.Firebrick;
                button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = false; button9.BackColor = Color.Firebrick; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White;
                button13.Enabled = false; button13.BackColor = Color.Firebrick; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick;
                button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = false; button19.BackColor = Color.Firebrick; button20.Enabled = true; button20.BackColor = Color.White;

            }
           else  if (comboBox2.Text == Sefer_Ucak.Bursa_İtalya.ToString())
            {
                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = true; button3.BackColor = Color.White; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = false; button7.BackColor = Color.Firebrick;
                button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = false; button9.BackColor = Color.Firebrick; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White;
                button13.Enabled = false; button13.BackColor = Color.Firebrick; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick;
                button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = false; button19.BackColor = Color.Firebrick; button20.Enabled = true; button20.BackColor = Color.White;

            }
            else if (comboBox2.Text == Sefer_Ucak.İstanbul_İtalya.ToString())
            {
                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = true; button3.BackColor = Color.White; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = false; button7.BackColor = Color.Firebrick;
                button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = false; button9.BackColor = Color.Firebrick; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White;
                button13.Enabled = false; button13.BackColor = Color.Firebrick; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick;
                button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = false; button19.BackColor = Color.Firebrick; button20.Enabled = true; button20.BackColor = Color.White;

            }
            else if (comboBox2.Text == Sefer_Ucak.İstanbul_Japonya.ToString())
            {
                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = false; button2.BackColor = Color.Firebrick; button3.Enabled = false; button3.BackColor = Color.Firebrick;
                button4.Enabled = false; button4.BackColor = Color.Firebrick; button5.Enabled = false; button5.BackColor = Color.Firebrick;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick;
                button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White;
                button14.Enabled = false; button14.BackColor = Color.Firebrick; button15.Enabled = true; button15.BackColor = Color.White;
                button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick;
                button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = true; button19.BackColor = Color.White; button20.Enabled = false; button20.BackColor = Color.Firebrick;

            }
            else if (comboBox2.Text == Sefer_Ucak.Ankara_Almanya.ToString())
            {
                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = true; button3.BackColor = Color.White; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = false; button7.BackColor = Color.Firebrick;
                button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = false; button9.BackColor = Color.Firebrick; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White;
                button13.Enabled = false; button13.BackColor = Color.Firebrick; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick;
                button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = false; button19.BackColor = Color.Firebrick; button20.Enabled = true; button20.BackColor = Color.White;

            }

            else if (comboBox2.Text == Sefer_Ucak.İstanbul_Arjantin.ToString())
            {
                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = true; button3.BackColor = Color.White; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = false; button7.BackColor = Color.Firebrick;
                button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = false; button9.BackColor = Color.Firebrick; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White;
                button13.Enabled = false; button13.BackColor = Color.Firebrick; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick;
                button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = false; button19.BackColor = Color.Firebrick; button20.Enabled = true; button20.BackColor = Color.White;

            }
            else if (comboBox2.Text == Sefer_Ucak.Ankara_Arjantin.ToString())
            {
                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = true; button3.BackColor = Color.White; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = false; button7.BackColor = Color.Firebrick;
                button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = false; button9.BackColor = Color.Firebrick; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White;
                button13.Enabled = false; button13.BackColor = Color.Firebrick; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick;
                button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = false; button19.BackColor = Color.Firebrick; button20.Enabled = true; button20.BackColor = Color.White;

            }
          
            else  if (comboBox2.Text == Sefer_Otobus.Adana_Nevşehir.ToString())
            {

                button1.Enabled = true; button1.BackColor = Color.White; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = true; button11.BackColor = Color.White; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = true; button17.BackColor = Color.White; button18.Enabled = true; button18.BackColor = Color.White;
                button19.Enabled = true; button19.BackColor = Color.White; button20.Enabled = true; button20.BackColor = Color.White;
            }
            else if (comboBox2.Text == Sefer_Otobus.İstanbul_Nevşehir.ToString())
            {

                button1.Enabled = true; button1.BackColor = Color.White; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = true; button11.BackColor = Color.White; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = true; button17.BackColor = Color.White; button18.Enabled = true; button18.BackColor = Color.White;
                button19.Enabled = true; button19.BackColor = Color.White; button20.Enabled = true; button20.BackColor = Color.White;
            }
            else if (comboBox2.Text == Sefer_Otobus.Ankara_Nevşehir.ToString())
            {

                button1.Enabled = true; button1.BackColor = Color.White; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = true; button11.BackColor = Color.White; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = true; button17.BackColor = Color.White; button18.Enabled = true; button18.BackColor = Color.White;
                button19.Enabled = true; button19.BackColor = Color.White; button20.Enabled = true; button20.BackColor = Color.White;
            }
            else  if (comboBox2.Text == Sefer_Otobus.Trabzon_Mardin.ToString())
            {

                button1.Enabled = true; button1.BackColor = Color.White; button2.Enabled = false; button2.BackColor = Color.Firebrick; button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White;
                button5.Enabled = false; button5.BackColor = Color.Firebrick;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = false; button9.BackColor = Color.Firebrick; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = false; button15.BackColor = Color.Firebrick; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick; button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = false; button19.BackColor = Color.Firebrick; button20.Enabled = false; button20.BackColor = Color.Firebrick;
            }
            else if (comboBox2.Text == Sefer_Otobus.İstanbul_Ankara.ToString())
            {

                button1.Enabled = true; button1.BackColor = Color.White; button2.Enabled = false; button2.BackColor = Color.Firebrick; button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White;
                button5.Enabled = false; button5.BackColor = Color.Firebrick;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = false; button9.BackColor = Color.Firebrick; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = false; button15.BackColor = Color.Firebrick; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick; button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = false; button19.BackColor = Color.Firebrick; button20.Enabled = false; button20.BackColor = Color.Firebrick;
            }
            else if (comboBox2.Text == Sefer_Otobus.Ankara_İstanbul.ToString())
            {

                button1.Enabled = true; button1.BackColor = Color.White; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = true; button11.BackColor = Color.White; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White; button14.Enabled = false; button14.BackColor = Color.Firebrick;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = true; button17.BackColor = Color.White; button18.Enabled = true; button18.BackColor = Color.White;
                button19.Enabled = true; button19.BackColor = Color.White; button20.Enabled = true; button20.BackColor = Color.White;
            }
            else  if (comboBox2.Text == Sefer_Otobus.Antalya_Ankara.ToString())
            {

                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White; button14.Enabled = true; button14.BackColor = Color.White;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick; button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = true; button19.BackColor = Color.White; button20.Enabled = true; button20.BackColor = Color.White;
            }
            else if (comboBox2.Text == Sefer_Otobus.Ankara_Mardin.ToString())
            {

                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White; button14.Enabled = true; button14.BackColor = Color.White;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick; button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = true; button19.BackColor = Color.White; button20.Enabled = true; button20.BackColor = Color.White;
            }
            else if (comboBox2.Text == Sefer_Otobus.İstanbul_Trabzon.ToString())
            {

                button1.Enabled = false; button1.BackColor = Color.Firebrick; button2.Enabled = true; button2.BackColor = Color.White; button3.Enabled = false; button3.BackColor = Color.Firebrick; button4.Enabled = true; button4.BackColor = Color.White; button5.Enabled = true; button5.BackColor = Color.White;
                button6.Enabled = false; button6.BackColor = Color.Firebrick; button7.Enabled = true; button7.BackColor = Color.White; button8.Enabled = false; button8.BackColor = Color.Firebrick; button9.Enabled = true; button9.BackColor = Color.White; button10.Enabled = true; button10.BackColor = Color.White;

                button11.Enabled = false; button11.BackColor = Color.Firebrick; button12.Enabled = true; button12.BackColor = Color.White; button13.Enabled = true; button13.BackColor = Color.White; button14.Enabled = true; button14.BackColor = Color.White;
                button15.Enabled = true; button15.BackColor = Color.White; button16.Enabled = false; button16.BackColor = Color.Firebrick; button17.Enabled = false; button17.BackColor = Color.Firebrick; button18.Enabled = false; button18.BackColor = Color.Firebrick;
                button19.Enabled = true; button19.BackColor = Color.White; button20.Enabled = true; button20.BackColor = Color.White;
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumAquamarine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.MediumAquamarine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.MediumAquamarine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.MediumAquamarine;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.MediumAquamarine;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.MediumAquamarine;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.MediumAquamarine;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.MediumAquamarine;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.MediumAquamarine;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.MediumAquamarine;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.MediumAquamarine;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.MediumAquamarine;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.MediumAquamarine;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.MediumAquamarine;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.MediumAquamarine;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.MediumAquamarine;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.MediumAquamarine;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.MediumAquamarine;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.MediumAquamarine;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.MediumAquamarine;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Odeme ödeme = new Odeme();
            this.Hide();
            ödeme.Show();
        }

       
    
    
        private void girişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
        }

        private void katalogSayfasıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Katalog katalog = new Katalog();
            this.Hide();
            katalog.Show();
        }

        private void müzeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            Muze müze = new Muze();
            this.Hide();
            müze.Show();
        }
        private void konaklamaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Otel yeni = new Otel();
            this.Hide();
            yeni.Show();

        }
 
        private void turToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            Tur tur = new Tur();
            this.Hide();
            tur.Show();
        }
        private void restoranToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            Restoran reestoran = new Restoran();
            this.Hide();
            reestoran.Show();
        }
        private void ödemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Odeme ödeme = new Odeme();
            this.Hide();
            ödeme.Show();
        }

        private void kayıtOlunToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kayitsayfasi yeni = new kayitsayfasi();
            yeni.Show();
            this.Hide();
        }
        private void girişYapınToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            girisYapin giris = new girisYapin();
            this.Hide();
            giris.Show();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            türkiye türkiye = new türkiye();
            türkiye.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dünya dünya = new dünya();
            dünya.Show();
            this.Hide();
        }

        

        Atama v= new Şehirler();
        Sepet sepet = new Sepet();
        public int a;
        public int b;
        public int fiyat;
       
        private void button22_Click(object sender, EventArgs e) //Sepete ekle butonu
        {
            sepet.Add(v);
            a = 250; 
            b = 50;

            UlasimSehir bilgi = new UlasimSehir();
            if (comboBox1.Text ==Ulasim_Yolu.Uçak.ToString())
            {
                bilgi.Fiyat = a;
                admingiris2.ulasımkisi = textBox4.Text;
                Sepet.fiyatulaşım = a.ToString();
            }

            else if (comboBox1.Text == Ulasim_Yolu.Otobus.ToString())
            {
                bilgi.Fiyat = b;
                Sepet.fiyatulaşım = b.ToString();
            }

            admingiris2.ulasımtoplami = label10.Text.ToString();
            Sepet.kisisayisiulaşım = textBox4.Text;  

            int kisi;
            Int32.TryParse(textBox4.Text, out kisi);
            UlasimSehir obje = new UlasimSehir();
            obje.kisi = kisi;
            obje.ulasim_yolu = comboBox1.Text;

            int toplam_fiyat = obje.Hesap(); 
            label10.Text = toplam_fiyat.ToString();
            Sepet.ulaşımtoplam = label10.Text.ToString(); 
            v.Fiyat = Convert.ToInt32(label10.Text);
            Sepet.total = sepet.TotalPrice();

            MessageBox.Show("Seçiminiz sepete eklenmiştir.");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void katalogToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void girişYapınToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }

}
