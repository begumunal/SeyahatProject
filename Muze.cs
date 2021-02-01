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
    public partial class Muze : Form
    {
        public Muze()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        Sepet sepet = new Sepet();
        
        Atama atama = new MuzeSehir();
        MuzeSehir muzeSehir = new MuzeSehir();
      

        public void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.AutoScroll = true;

            Atama.kategori = "Muze";
          
           
            label1.Text = Atama.isim;
            label3.Text = muzeSehir.txt1;
            label5.Text = muzeSehir.txt3;
            button1.Text = muzeSehir.txt4;
            button2.Text = muzeSehir.txt5;
            button3.Text = muzeSehir.txt6 ;
            button4.Text = muzeSehir.txt7;
            label46.Text = "* Seçmek zorunludur.";

          
            label47.Text = GırısAtama.kullanıcı;
            if ((label47.Text != GırısAtama.kullanıcı) || (GırısAtama.kullanıcı == "0"))
            {
                label47.Text = "Giriş Yapınız.";
                label47.ForeColor = Color.Maroon;
            }
            else
            {
                label47.Text = "HOŞGELDİN " + GırısAtama.kullanıcı ;
                label47.ForeColor = Color.SeaGreen;
            }
           
            sepet.Add(muzeSehir);


            pictureBox31.ImageLocation = "museum3.png";
            pictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox7.ImageLocation = "visitors.png";
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox8.ImageLocation = "museum-ticket.png";
            pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox9.ImageLocation = "museum1.png";
            pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox10.ImageLocation = "museum2.png";
            pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox12.ImageLocation = "visitors.png";
            pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox11.ImageLocation = "museum-ticket.png";
            pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox13.ImageLocation = "museum1.png";
            pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox14.ImageLocation = "museum2.png";
            pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox17.ImageLocation = "visitors.png";
            pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox18.ImageLocation = "museum-ticket.png";
            pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox16.ImageLocation = "museum1.png";
            pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox15.ImageLocation = "museum2.png";
            pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox20.ImageLocation = "visitors.png";
            pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox21.ImageLocation = "museum-ticket.png";
            pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox19.ImageLocation = "museum1.png";
            pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.ImageLocation = "museum2.png";
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox23.ImageLocation = "visitors.png";
            pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox24.ImageLocation = "museum-ticket.png";
            pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.ImageLocation = "museum1.png";
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = "museum2.png";
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox28.ImageLocation = "visitors.png";
            pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox29.ImageLocation = "museum-ticket.png";
            pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox27.ImageLocation = "museum1.png";
            pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox26.ImageLocation = "museum2.png";
            pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox32.ImageLocation = "logo1.png";
            pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            label31.Text = muzeSehir.text1;
            label6.Text = muzeSehir.gun;
            label24.Text = "Açılış: 10:00" + " Kapanış: 17:00";
            label7.Text = muzeSehir.text2;

            label23.Text = muzeSehir.text1;
            label10.Text = muzeSehir.gun1;
            label28.Text = "Açılış: 10:00" + " Kapanış: 17:00";
            label27.Text = muzeSehir.text2;

            label12.Text = muzeSehir.text1;
            label29.Text = muzeSehir.gun;
            label14.Text = "Açılış: 08:00" + " Kapanış: 19:00";
            label13.Text = muzeSehir.text2;

            label20.Text = muzeSehir.text1;
            label33.Text = muzeSehir.gun;
            label22.Text = "Açılış: 08:00" + " Kapanış: 19:00";
            label21.Text = muzeSehir.text2;

            label2.Text = muzeSehir.text1;
            label18.Text = muzeSehir.gun;
            label16.Text = "Açılış: 10:00" + " Kapanış: 19:00";
            label15.Text = muzeSehir.text2;

            label35.Text = muzeSehir.text1;
            label39.Text = muzeSehir.gun;
            label37.Text = "Açılış: 10:00" + " Kapanış: 17:00";
            label36.Text = muzeSehir.text2;

           
            if (Atama.isim == "Nevşehir")
            {
               
                sepet.birim = atama.x;

                
                label4.Text = muzeSehir.x;
                label41.Text = muzeSehir.x;
                label42.Text = muzeSehir.x;
                label43.Text = muzeSehir.x;
                label44.Text = muzeSehir.x;
                label45.Text = muzeSehir.x;

              
                radioButton3.Text = MuzeIsmi.NevsehirMuzesi.ToString();
                radioButton4.Text = MuzeIsmi.ZelveAçıkHavaMüzesi.ToString();
                radioButton2.Text = MuzeIsmi.GöremeAçıkHavaMüzesi.ToString();
                radioButton5.Text = MuzeIsmi.KaymaklıYeraltıŞehri.ToString();
                radioButton6.Text = MuzeIsmi.AçıksarayÖrenyeri.ToString();
                radioButton7.Text = MuzeIsmi.StJeanKilisesi.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                    
                    muzeSehir.Kayıt(MuzeIsmi.NevsehirMuzesi);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = " 350 Evler Mh., 50300 Nevşehir, Türkiye";

                    muzeSehir.Kayıt(MuzeIsmi.ZelveAçıkHavaMüzesi);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = "Zelve Yolu, Nevşehir Türkiye";

                    muzeSehir.Kayıt(MuzeIsmi.GöremeAçıkHavaMüzesi);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = "50180 Göreme,Nevşehir";

                    muzeSehir.Kayıt(MuzeIsmi.KaymaklıYeraltıŞehri);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "Cami Kebir Mh. 50760 Kaymaklı/Nevşehir";

                    muzeSehir.Kayıt(MuzeIsmi.AçıksarayÖrenyeri);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = " Nevşehir Gülşehir";

                    muzeSehir.Kayıt(MuzeIsmi.StJeanKilisesi);                   
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = " Nevşehir Gülşehir";

                    
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }

                pictureBox1.ImageLocation = "nevsehir-muzesi.jpg";
                pictureBox2.ImageLocation = "zelve-açık-hava-müzesi.jpg";
                pictureBox3.ImageLocation = "göreme-acık-hava-muzesi-1.jpg";
                pictureBox22.ImageLocation = "kapadokya-yeralti-sehirleri.jpg";
                pictureBox25.ImageLocation = "gulsehir-kapadokyaq1.jpg";
                pictureBox30.ImageLocation = "ST.Jean1.jpg";



            }

            else if (Atama.isim == "İstanbul")
            {
              
                sepet.birim = atama.x;

                
                label4.Text = muzeSehir.x;
                label41.Text = muzeSehir.x;
                label42.Text = muzeSehir.x;
                label43.Text = muzeSehir.x;
                label44.Text = muzeSehir.x;
                label45.Text = muzeSehir.x;

                
                radioButton3.Text = MuzeIsmi.TopkapıSarayı.ToString();
                radioButton4.Text = MuzeIsmi.İstanbulArkeolojiMüzesi.ToString();
                radioButton2.Text = MuzeIsmi.DenizMüzesi.ToString();
                radioButton5.Text = MuzeIsmi.YerebatanSarnıcı.ToString();
                radioButton6.Text = MuzeIsmi.OyuncakMüzesi.ToString();
                radioButton7.Text = MuzeIsmi.KlasikOtmobilMüzesi.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                   
                    muzeSehir.Kayıt(MuzeIsmi.TopkapıSarayı);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = " Cankurtaran, 34122 Fatih/İstanbul, Türkiye";

                    muzeSehir.Kayıt(MuzeIsmi.İstanbulArkeolojiMüzesi);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = "Cankurtaran, 34122 Fatih/İstanbul Türkiye";

                    muzeSehir.Kayıt(MuzeIsmi.DenizMüzesi);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = "Sinanpaşa, 34353 Beşiktaş/İstanbul";

                    muzeSehir.Kayıt(MuzeIsmi.YerebatanSarnıcı);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "Alemdar, 34110 Fatih/İstanbul";

                    muzeSehir.Kayıt(MuzeIsmi.OyuncakMüzesi);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = "Göztepe Mah. No:17, 34730 Kadıköy";

                    muzeSehir.Kayıt(MuzeIsmi.KlasikOtmobilMüzesi);
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = "Ferahevler, 34457 Sarıyer/İstanbul";

                   
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }

              
                pictureBox1.ImageLocation = "Topkapi Palace.jpg";
                pictureBox2.ImageLocation = "İstanbul Arkeoloji Müzesi.jpg";
                pictureBox3.ImageLocation = "DenizMuzesi.png";
                pictureBox22.ImageLocation = "Yerebatan Sarnıcı.jpg";
                pictureBox25.ImageLocation = "Oyuncak Muzesi.jpg";
                pictureBox30.ImageLocation = "Klasik Otomobil Muzesi.jpg";



            }

            else if (Atama.isim == "Antalya")
            {
               
                sepet.birim = atama.x;

               
                label4.Text = muzeSehir.x;
                label41.Text = muzeSehir.x;
                label42.Text = muzeSehir.x;
                label43.Text = muzeSehir.x;
                label44.Text = muzeSehir.x;
                label45.Text = muzeSehir.x;

              
                radioButton3.Text = MuzeIsmi.AntalyaMuzesi.ToString();
                radioButton4.Text = MuzeIsmi.SunaİnanKaleiçiMüzesi.ToString();
                radioButton2.Text = MuzeIsmi.DenizBiyolojisiMüzesi.ToString();
                radioButton5.Text = MuzeIsmi.Sandland.ToString();
                radioButton6.Text = MuzeIsmi.HababamSınıfıMüzesi.ToString();
                radioButton7.Text = MuzeIsmi.EtnografyaMüzesi.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                   
                    muzeSehir.Kayıt(MuzeIsmi.AntalyaMuzesi);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = "Bahçelievler, 07050 Muratpaşa/Antalya";

                    muzeSehir.Kayıt(MuzeIsmi.SunaİnanKaleiçiMüzesi);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = "Barbaros, 07100 Muratpaşa/Antalya";

                    muzeSehir.Kayıt(MuzeIsmi.DenizBiyolojisiMüzesi);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = "Selçuk, Selçuk Mah, 07100 Muratpaşa/Antalya";

                    muzeSehir.Kayıt(MuzeIsmi.Sandland);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "Lara Halk Plajı, 07230 Muratpaşa/Antalya";

                    muzeSehir.Kayıt(MuzeIsmi.HababamSınıfıMüzesi);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = "Esentepe, 4980. Sk., 07020 Kepez/Antalya";

                    muzeSehir.Kayıt(MuzeIsmi.EtnografyaMüzesi);
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = "Kılınçarslan Mahallesi Muratpaşa / ANTALYA";

                   
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }

               
                pictureBox1.ImageLocation = "AntalyaMuzesi .jpg";
                pictureBox2.ImageLocation = "SunaInanKaleiciMuzesi.jpg";
                pictureBox3.ImageLocation = "denizbiyolojisimuzesi.jpg";
                pictureBox22.ImageLocation = "sandland.jpg";
                pictureBox25.ImageLocation = "HababamSinifiMuzesi .jpg";
                pictureBox30.ImageLocation = "EtnografyaMuzesi .jpg";


            }

            else if (Atama.isim == "Mardin")
            {
               
                sepet.birim = atama.x;

               
                label4.Text = muzeSehir.x;
                label41.Text = muzeSehir.x;
                label42.Text = muzeSehir.x;
                label43.Text = muzeSehir.x;
                label44.Text = muzeSehir.x;
                label45.Text = muzeSehir.x;

              
                radioButton3.Text = MuzeIsmi.MardinMüzesi.ToString();
                radioButton4.Text = MuzeIsmi.SakıpSabancıKentMüzesi.ToString();
                radioButton2.Text = MuzeIsmi.EğitimTarihiMüzesiArtuklu.ToString();
                radioButton5.Text = MuzeIsmi.MidyatKonukevi.ToString();
                radioButton6.Text = MuzeIsmi.MorBehnamKırklıKilisesi.ToString();
                radioButton7.Text = MuzeIsmi.DaraAntikKenti.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                    muzeSehir.Kayıt(MuzeIsmi.MardinMüzesi);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = "Şar, 47100 Artuklu, Türkiye";

                    muzeSehir.Kayıt(MuzeIsmi.SakıpSabancıKentMüzesi);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = "Şehidiye, 47100 Mardin Merkez/Mardin";

                    muzeSehir.Kayıt(MuzeIsmi.EğitimTarihiMüzesiArtuklu);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = "Latifiye, 1. Cadde No:417, 47100 Artuklu/Mardin";

                    muzeSehir.Kayıt(MuzeIsmi.MidyatKonukevi);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "Akçakaya, 148. Sk., 47510 Midyat/Mardin";

                    muzeSehir.Kayıt(MuzeIsmi.MorBehnamKırklıKilisesi);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = "Şar, 1. Cadde No:416, 47100 Merkez/Mardin";

                    muzeSehir.Kayıt(MuzeIsmi.DaraAntikKenti);
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = "Dara Köyü, Artuklu Mardin";

                   
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }

               
                pictureBox1.ImageLocation = "MardinMüzesi.jpg";
                pictureBox2.ImageLocation = "SakıpSabancıKentMüzesi.jpg";
                pictureBox3.ImageLocation = "EgitimTarihiMüzesiArtuklu.jpg";
                pictureBox22.ImageLocation = "midyatkonukevi.jpg";
                pictureBox25.ImageLocation = "MorBehnamKırklıKilisesi.jpg";
                pictureBox30.ImageLocation = "DaraAntikKenti .jpg";


            }

            else if (Atama.isim == "Trabzon")
            {
              
                sepet.birim = atama.x;

              
                label4.Text = muzeSehir.x;
                label41.Text = muzeSehir.x;
                label42.Text = muzeSehir.x;
                label43.Text = muzeSehir.x;
                label44.Text = muzeSehir.x;
                label45.Text = muzeSehir.x;

               
                radioButton3.Text = MuzeIsmi.SümelaManastırı.ToString();
                radioButton4.Text = MuzeIsmi.TrabzonMüzesi.ToString();
                radioButton2.Text = MuzeIsmi.AtatürkKöşkü.ToString();
                radioButton5.Text = MuzeIsmi.OrtahisarTarihMüzesi.ToString();
                radioButton6.Text = MuzeIsmi.EdebiyatMüzesi.ToString();
                radioButton7.Text = MuzeIsmi.TrabzonSporMüzesi.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                  
                    muzeSehir.Kayıt(MuzeIsmi.SümelaManastırı);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = "Altındere, 61750 Maçka/Trabzon, Türkiye";

                    muzeSehir.Kayıt(MuzeIsmi.TrabzonMüzesi);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = "Gazipaşa, 61030 Trabzon Merkez/Trabzon";

                    muzeSehir.Kayıt(MuzeIsmi.AtatürkKöşkü);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = "Soğuksu, Ata Cd. No:1, 61040 Ortahisar/Trabzon";

                    muzeSehir.Kayıt(MuzeIsmi.OrtahisarTarihMüzesi);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "Ortahisar, 61030 Trabzon Merkez";

                    muzeSehir.Kayıt(MuzeIsmi.EdebiyatMüzesi);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = " Ortahisar, 61030 Merkez/Trabzon";

                    muzeSehir.Kayıt(MuzeIsmi.TrabzonSporMüzesi);
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = "Kemerkaya, 61200 Trabzon Merkez/Trabzon";

                  
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }

             
                pictureBox1.ImageLocation = "SumelaManastırı.jpg";
                pictureBox2.ImageLocation = "TRABZON-MUZESI .jpg";
                pictureBox3.ImageLocation = "trabzonataturkkosku .jpg";
                pictureBox22.ImageLocation = "TrabzonOrtahisarTarihMüzesi.jpg";
                pictureBox25.ImageLocation = "EdebiyatMüzesi.jpg";
                pictureBox30.ImageLocation = "trabzonsporsamilekinciMüzesi.jpg";
            }

            else if (Atama.isim == "Ankara")
            {
              
               sepet.birim = atama.x;

       
                label4.Text = muzeSehir.x;
                label41.Text = muzeSehir.x;
                label42.Text = muzeSehir.x;
                label43.Text = muzeSehir.x;
                label44.Text = muzeSehir.x;
                label45.Text = muzeSehir.x;

               
                radioButton3.Text = MuzeIsmi.AtatürkveKurtuluşSavaşıMüzesiAnıtkabir.ToString();
                radioButton4.Text = MuzeIsmi.CumhuriyetMüzesi.ToString();
                radioButton2.Text = MuzeIsmi.KurtuluşSavaşıMüzesi.ToString();
                radioButton5.Text = MuzeIsmi.AnadoluMedeniyetleriMüzesi.ToString();
                radioButton6.Text = MuzeIsmi.EtnografyaMuzesiAnkara.ToString();
                radioButton7.Text = MuzeIsmi.ODTÜBilimveTeknolojiMüzesi.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                 
                    muzeSehir.Kayıt(MuzeIsmi.AtatürkveKurtuluşSavaşıMüzesiAnıtkabir);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = "Maltepe, Anıt Cd., 06570 Çankaya/Ankara, Türkiye";

                    muzeSehir.Kayıt(MuzeIsmi.CumhuriyetMüzesi);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = " Doğanbey, 06050 Altındağ/Ankara";

                    muzeSehir.Kayıt(MuzeIsmi.KurtuluşSavaşıMüzesi);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = "Anafartalar, 06050 Altındağ/Ankara";

                    muzeSehir.Kayıt(MuzeIsmi.AnadoluMedeniyetleriMüzesi);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "Kale, Gözcü Sk. No:2, 06240 Ulus/Altındağ";

                    muzeSehir.Kayıt(MuzeIsmi.EtnografyaMuzesiAnkara);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = "Opera, Sıhhiye, Ankara";

                    muzeSehir.Kayıt(MuzeIsmi.ODTÜBilimveTeknolojiMüzesi);
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = "Üniversiteler, 06800 Çankaya/Ankara";

                  
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }

               
                pictureBox1.ImageLocation = "Atatürk ve Kurtuluş Savaşı MüzesiAnıtkabir.jpg";
                pictureBox2.ImageLocation = "CumhuriyetMüzesi.jpg";
                pictureBox3.ImageLocation = "KurtuluşSavaşıMüzesi.png";
                pictureBox22.ImageLocation = "AnadoluMedeniyetleriMüzesi.jpg";
                pictureBox25.ImageLocation = "EtnografyaMuzesiAnkara.jpg";
                pictureBox30.ImageLocation = "ODTÜBilimveTeknolojiMüzesi.jpg";
            }

            else if (Atama.isim == "Almanya")
            {
               
                sepet.birim = atama.y;

               
                label4.Text = muzeSehir.y;
                label41.Text = muzeSehir.y;
                label42.Text = muzeSehir.y;
                label43.Text = muzeSehir.y;
                label44.Text = muzeSehir.y;
                label45.Text = muzeSehir.y;

             
                radioButton3.Text = MuzeIsmi.BergamaMuseum.ToString();
                radioButton4.Text = MuzeIsmi.AlteNationalGalerie.ToString();
                radioButton2.Text = MuzeIsmi.BodeMuseum.ToString();
                radioButton5.Text = MuzeIsmi.AltePinakothek.ToString();
                radioButton6.Text = MuzeIsmi.SenckenbergMuseum.ToString();
                radioButton7.Text = MuzeIsmi.StädelMuseum.ToString();

                foreach (var prd in sepet.GetAtama())
                {
              
                    muzeSehir.Kayıt(MuzeIsmi.BergamaMuseum);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = "Bodestraße 1-3, 10178 Berlin, Almanya";

                    muzeSehir.Kayıt(MuzeIsmi.AlteNationalGalerie);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = "Bodestraße 1-3, 10178 Berlin, Almanya";

                    muzeSehir.Kayıt(MuzeIsmi.BodeMuseum);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = "Am Kupfergraben, 10117 Berlin, Almanya";

                    muzeSehir.Kayıt(MuzeIsmi.AltePinakothek);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "Barer Str. 27, 80333 München, Almanya";

                    muzeSehir.Kayıt(MuzeIsmi.SenckenbergMuseum);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = "Senckenberganlage 25, 60325 Frankfurt am Main";

                    muzeSehir.Kayıt(MuzeIsmi.StädelMuseum);
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = "Schaumainkai 63, 60596 Frankfurt am Main";

                 
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }

              
                pictureBox1.ImageLocation = "BergamaMuseum.jpg";
                pictureBox2.ImageLocation = "ALTENATIONALGALERIE.jpg";
                pictureBox3.ImageLocation = "BodeMuseum .jpg";
                pictureBox22.ImageLocation = "altepinakothek.jpg";
                pictureBox25.ImageLocation = "SenckenbergMuseum.jpg";
                pictureBox30.ImageLocation = "StaedelMuseum.jpg";
            }

            else if (Atama.isim == "İtalya")
            {
               
                sepet.birim = atama.y;

                
                label4.Text = muzeSehir.y;
                label41.Text = muzeSehir.y;
                label42.Text = muzeSehir.y;
                label43.Text = muzeSehir.y;
                label44.Text = muzeSehir.y;
                label45.Text = muzeSehir.y;

               
                radioButton3.Text = MuzeIsmi.GalleriaBorghese.ToString();
                radioButton4.Text = MuzeIsmi.Uffizi.ToString();
                radioButton2.Text = MuzeIsmi.PittiPalace.ToString();
                radioButton5.Text = MuzeIsmi.CaptaliniMuseum.ToString();
                radioButton6.Text = MuzeIsmi.Pantheon.ToString();
                radioButton7.Text = MuzeIsmi.GalileoMuseum.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                  
                    muzeSehir.Kayıt(MuzeIsmi.GalleriaBorghese);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = "Piazzale Scipione Borghese, 5, 00197 Roma RM, İtalya";

                    muzeSehir.Kayıt(MuzeIsmi.Uffizi);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = " Piazzale degli Uffizi, 6, 50122 Firenze FI, İtalya";

                    muzeSehir.Kayıt(MuzeIsmi.PittiPalace);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = "Piazza de' Pitti, 1, 50125 Firenze FI, İtalya";

                    muzeSehir.Kayıt(MuzeIsmi.CaptaliniMuseum);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "Piazza del Campidoglio, 1, 00186 Roma RM, İtalya";

                    muzeSehir.Kayıt(MuzeIsmi.Pantheon);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = " Piazza della Rotonda, 00186 Roma RM, İtalya";

                    muzeSehir.Kayıt(MuzeIsmi.GalileoMuseum);
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = "Piazza dei Giudici, 1, 50122 Firenze FI, İtalya";

                
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }

                
                pictureBox1.ImageLocation = "GalleriaBorghese.jpg";
                pictureBox2.ImageLocation = "Uffizi.jpg";
                pictureBox3.ImageLocation = "PittiPalace.jpg";
                pictureBox22.ImageLocation = "CaptaliniMuseum.jpg";
                pictureBox25.ImageLocation = "Pantheon.jpg";
                pictureBox30.ImageLocation = "GalileoMuseum.jpg";
            }

            else if (Atama.isim == "Arjantin")
            {
               
                sepet.birim = atama.y;

                
                label4.Text = muzeSehir.z;
                label41.Text = muzeSehir.z;
                label42.Text = muzeSehir.z;
                label43.Text = muzeSehir.z;
                label44.Text = muzeSehir.z;
                label45.Text = muzeSehir.z;

                
                radioButton3.Text = MuzeIsmi.MuseoNacionaldeArteDecorativo.ToString();
                radioButton4.Text = MuzeIsmi.BenitoQuinquelaMartínMuseum.ToString();
                radioButton2.Text = MuzeIsmi.MuseoDeLaPlata.ToString();
                radioButton5.Text = MuzeIsmi.XulSolarMuseum.ToString();
                radioButton6.Text = MuzeIsmi.AmaliaLacrozdeFortabatArtCollection.ToString();
                radioButton7.Text = MuzeIsmi.MuseodeArteContemporáneodeSalta.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                  
                    muzeSehir.Kayıt(MuzeIsmi.MuseoNacionaldeArteDecorativo);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = " Av. del Libertador 1902, C1425 CABA, Arjantin";

                    muzeSehir.Kayıt(MuzeIsmi.BenitoQuinquelaMartínMuseum);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = "Av. Don Pedro de Mendoza 1835, Buenos Aires";

                    muzeSehir.Kayıt(MuzeIsmi.MuseoDeLaPlata);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = "Paseo del Bosque s/n, B1900 La Plata Buenos Aires";

                    muzeSehir.Kayıt(MuzeIsmi.XulSolarMuseum);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "Laprida 1212, C1425 EKF, Buenos Aires, Arjantin";

                    muzeSehir.Kayıt(MuzeIsmi.AmaliaLacrozdeFortabatArtCollection);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = "Olga Cossettini 141, C1107 CABA, Arjantin";

                    muzeSehir.Kayıt(MuzeIsmi.MuseodeArteContemporáneodeSalta);
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = "Independencia 122, X5000 Córdoba, Arjantin";

                    
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }

               
                pictureBox1.ImageLocation = "Museo Nacional de Arte Decorativo.jpg";
                pictureBox2.ImageLocation = "BenitoQuinquelaMartínMuseum.jpg";
                pictureBox3.ImageLocation = "MuseoDeLaPlata.jpg";
                pictureBox22.ImageLocation = "XulSolarMuseum.jpg";
                pictureBox25.ImageLocation = "AmaliaLacrozdeFortabatArtCollection.jpg";
                pictureBox30.ImageLocation = "MuseodeArteContemporáneodeSalta.jpg";
            }

            else if (Atama.isim == "Japonya")
            {
               
               sepet.birim = atama.k;

               
                label4.Text = muzeSehir.k;
                label41.Text = muzeSehir.k;
                label42.Text = muzeSehir.k;
                label43.Text = muzeSehir.k;
                label44.Text = muzeSehir.k;
                label45.Text = muzeSehir.k;

              
                radioButton3.Text = MuzeIsmi.TokyoNationalMuseum.ToString();
                radioButton4.Text = MuzeIsmi.TeamLabPlanets.ToString();
                radioButton2.Text = MuzeIsmi.OharaMuseumofArt.ToString();
                radioButton5.Text = MuzeIsmi.MihoMuseum.ToString();
                radioButton6.Text = MuzeIsmi.PolaMuseumofArt.ToString();
                radioButton7.Text = MuzeIsmi.TokyoNationalMuseumHeiseikan.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                    
                    muzeSehir.Kayıt(MuzeIsmi.TokyoNationalMuseum);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = " 13-9 Uenokoen, Taito City, Tokyo 110-8712";

                    muzeSehir.Kayıt(MuzeIsmi.TeamLabPlanets);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = "6 Chome-1-16 Toyosu, Koto City, Tokyo 135-0061";

                    muzeSehir.Kayıt(MuzeIsmi.OharaMuseumofArt);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = " 1 Chome-1-15 Central, Kurashiki, Okayama 710-0046";

                    muzeSehir.Kayıt(MuzeIsmi.MihoMuseum);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "桃谷-300 Shigarakicho Tashiro, Shiga 529-1814";

                    muzeSehir.Kayıt(MuzeIsmi.PolaMuseumofArt);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = "〒250-0631 Kanagawa,Sengokuhara, 小塚山１２８５";

                    muzeSehir.Kayıt(MuzeIsmi.TokyoNationalMuseumHeiseikan);
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = "〒110-0007 Tokyo, Uenokoen, 13−9 東京国立博物館内";

                    
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }

               
                pictureBox1.ImageLocation = "TokyoUlusalMüzesi.jpg";
                pictureBox2.ImageLocation = "TeamLabPlanets.jpg";
                pictureBox3.ImageLocation = "OharaMuseumofArt.jpg";
                pictureBox22.ImageLocation = "MihoMuseum.jpg";
                pictureBox25.ImageLocation = "PolaMuseumofArt.jpg";
                pictureBox30.ImageLocation = "TokyoNationalMuseumHeiseikan.jpg";
            }

            else if (Atama.isim == "Norveç")
            {
                
                sepet.birim = atama.t;

               
                label4.Text = muzeSehir.t;
                label41.Text = muzeSehir.t;
                label42.Text = muzeSehir.t;
                label43.Text = muzeSehir.t;
                label44.Text = muzeSehir.t;
                label45.Text = muzeSehir.t;

               
                radioButton3.Text = MuzeIsmi.TheFramMuseum.ToString();
                radioButton4.Text = MuzeIsmi.NorwegianMaritimeMuseum.ToString();
                radioButton2.Text = MuzeIsmi.TheNorwegianMuseumofCulturalHistory.ToString();
                radioButton5.Text = MuzeIsmi.NobelPeaceCenter.ToString();
                radioButton6.Text = MuzeIsmi.OscarshallPalace.ToString();
                radioButton7.Text = MuzeIsmi.KistefosMuseum.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                 
                    muzeSehir.Kayıt(MuzeIsmi.TheFramMuseum);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label8.Text = "Bygdøynesveien 39, 0286 Oslo, Norveç";

                    muzeSehir.Kayıt(MuzeIsmi.NorwegianMaritimeMuseum);
                    label11.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label9.Text = " Bygdøynesveien 37, 0286 Oslo, Norveç";

                    muzeSehir.Kayıt(MuzeIsmi.TheNorwegianMuseumofCulturalHistory);
                    label30.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label26.Text = " Museumsveien 10, 0287 Oslo, Norveç";

                    muzeSehir.Kayıt(MuzeIsmi.NobelPeaceCenter);
                    label34.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label32.Text = "Brynjulf Bulls plass 1, 0250 Oslo, Norveç";

                    muzeSehir.Kayıt(MuzeIsmi.OscarshallPalace);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label17.Text = "Oscarshallveien, 0287 Oslo, Norveç";

                    muzeSehir.Kayıt(MuzeIsmi.KistefosMuseum);
                    label40.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = " Samsmoveien 41, 3520 Jevnaker, Norveç";

                  
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);

                }

                
                pictureBox1.ImageLocation = "TheFramMuseum.jpg";
                pictureBox2.ImageLocation = "NorwegianMaritimeMuseum.jpg";
                pictureBox3.ImageLocation = "TheNorwegianMuseumofCulturalHistory.jpg";
                pictureBox22.ImageLocation = "NobelPeaceCenter.jpg";
                pictureBox25.ImageLocation = "OscarshallPalace.jpg";
                pictureBox30.ImageLocation = "KistefosMuseum.png";
            }

            else
            {
                this.Close();
                MessageBox.Show("Aradiginiz Sehir Bulunamadi..");
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
          
           
            int c;
            int[] fyt;
            fyt = muzeSehir.fyt;

           
            for (int b = 0; b < 17; b++)
            {
                c = fyt[b];
                if (comboBox2.Text == c.ToString())
                {
                    if (label25.Text == c.ToString())
                    {
                        panel1.BackColor = Color.DarkGray;
                        label25.ForeColor = Color.White;
                        label25.BackColor = Color.Green;
                    }
                     if (label11.Text == c.ToString())
                    {
                        panel2.BackColor = Color.DarkGray;
                        label11.ForeColor = Color.White;
                        label11.BackColor = Color.Green;
                    }
                     if (label30.Text == c.ToString())
                    {
                        panel3.BackColor = Color.DarkGray;
                        label30.ForeColor = Color.White;
                        label30.BackColor = Color.Green;
                    }
                    if (label34.Text == c.ToString())
                    {
                        panel4.BackColor = Color.DarkGray;
                        label34.ForeColor = Color.White;
                        label34.BackColor = Color.Green;
                    }
                    if (label19.Text == c.ToString())
                    {
                        panel5.BackColor = Color.DarkGray;
                        label19.ForeColor = Color.White;
                        label19.BackColor = Color.Green;
                    }
                    if (label40.Text == c.ToString())
                    {
                        panel7.BackColor = Color.DarkGray;
                        label40.ForeColor = Color.White;
                        label40.BackColor = Color.Green;
                    }
                }

            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            comboBox2.Text = " ";

            panel1.BackColor = Color.Silver;
            panel2.BackColor = Color.Silver;
            panel3.BackColor = Color.Silver;
            panel4.BackColor = Color.Silver;
            panel5.BackColor = Color.Silver;
            panel7.BackColor = Color.Silver;

            label25.ForeColor = Color.Black;
            label25.BackColor = Color.Silver;

            label11.ForeColor = Color.Black;
            label11.BackColor = Color.Silver;

            label30.ForeColor = Color.Black;
            label30.BackColor = Color.Silver;

            label34.ForeColor = Color.Black;
            label34.BackColor = Color.Silver;

            label19.ForeColor = Color.Black;
            label19.BackColor = Color.Silver;

            label40.ForeColor = Color.Black;
            label40.BackColor = Color.Silver;

        }

     
        Odeme odeme = new Odeme();


     
        private void button3_Click(object sender, EventArgs e)
        {
            
            Sepet.kisisayisimüze = textBox1.Text;
            admingiris2.muzekisi = textBox1.Text;


            if (radioButton3.Checked)
            {
                muzeSehir.Fiyat = Convert.ToInt32(label25.Text);
                muzeSehir.gonder(radioButton3.Text, muzeSehir.Fiyat, Convert.ToInt32(textBox1.Text));
                Sepet.günlükfiyatmüze = muzeSehir.Fiyat.ToString();

            }
            else if (radioButton4.Checked)
            {
                muzeSehir.Fiyat = Convert.ToInt32(label11.Text);
                muzeSehir.gonder(radioButton4.Text, muzeSehir.Fiyat, Convert.ToInt32(textBox1.Text));
                Sepet.günlükfiyatmüze = muzeSehir.Fiyat.ToString();

            }
            else if (radioButton2.Checked)
            {
                muzeSehir.Fiyat = Convert.ToInt32(label30.Text);
                muzeSehir.gonder(radioButton2.Text, muzeSehir.Fiyat, Convert.ToInt32(textBox1.Text));
                Sepet.günlükfiyatmüze = muzeSehir.Fiyat.ToString();

            }
            else if (radioButton5.Checked)
            {
                muzeSehir.Fiyat = Convert.ToInt32(label34.Text);
                muzeSehir.gonder(radioButton5.Text, muzeSehir.Fiyat, Convert.ToInt32(textBox1.Text));
                Sepet.günlükfiyatmüze = muzeSehir.Fiyat.ToString();

            }
            else if (radioButton6.Checked)
            {
                muzeSehir.Fiyat = Convert.ToInt32(label19.Text);
                muzeSehir.gonder(radioButton6.Text, muzeSehir.Fiyat, Convert.ToInt32(textBox1.Text));
                Sepet.günlükfiyatmüze = muzeSehir.Fiyat.ToString();

            }
            else if (radioButton7.Checked)
            {
                muzeSehir.Fiyat = Convert.ToInt32(label40.Text);
                muzeSehir.gonder(radioButton2.Text, muzeSehir.Fiyat, Convert.ToInt32(textBox1.Text));
                Sepet.günlükfiyatmüze = muzeSehir.Fiyat.ToString();
            }
            Sepet.müzeisim = muzeSehir.muzeismi;
            muzeSehir.Hesap();
            Sepet.müzetoplam = muzeSehir.toplam.ToString();
           
            admingiris2.muzetoplami = muzeSehir.toplam.ToString();
            muzeSehir.Fiyat = muzeSehir.toplam;
           
            Sepet.total = sepet.TotalPrice();
            MessageBox.Show("Seçiminiz Sepete Eklenmiştir");
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }


     
        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            odeme.Show();
        }

        Otel otel = new Otel();
        Tur tur = new Tur();
        Katalog katalog = new Katalog();

      
        private void katalogSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            katalog.Show();
        }

        private void restoranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restoran reestoran = new Restoran();
            this.Hide();
            reestoran.Show();
        }

        private void konaklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            otel.Show();
        }

        private void turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tur.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void müzeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kayıtOlunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitsayfasi yeni = new kayitsayfasi();
            yeni.Show();
            this.Hide();
        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odeme ödeme = new Odeme();
            this.Hide();
            ödeme.Show();
        }

      
       
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            türkiye türkiye = new türkiye();
            türkiye.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dünya dünya = new dünya();
            dünya.Show();
            this.Hide();
        }

        private void ulaşımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ULASIM ulaşım = new ULASIM();
            ulaşım.Show();
            this.Hide();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
        }

        private void girişYapınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            girisYapin giris = new girisYapin();
            this.Hide();
            giris.Show();
        }
    }
}

