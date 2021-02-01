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
    public partial class Tur : Form
    {
        public Tur()
        {
            InitializeComponent();
        }

        
        Sepet base3 = new Sepet();

       
        Atama atama = new TurSehir(); 

        TurSehir turSehir = new TurSehir(); 

        private void Form3_Load(object sender, EventArgs e)
        {
            Atama.kategori = "Tur";

           
            this.MaximizeBox = false;
           
           
            label2.Text = turSehir.a;

            label1.Text = turSehir.m1;
            label3.Text = turSehir.m3;
            label4.Text = turSehir.m4;
            label5.Text = turSehir.m5;
            label38.Text = turSehir.m6;
            label39.Text = turSehir.m7;
            label10.Text = turSehir.o1;
            label11.Text = turSehir.o2;
            label12.Text = turSehir.o3;
            label17.Text = turSehir.o1;
            label18.Text = turSehir.o2;
            label19.Text = turSehir.o3;
            label24.Text = turSehir.o1;
            label25.Text = turSehir.o2;
            label26.Text = turSehir.o3;
            label31.Text = turSehir.o1;
            label32.Text = turSehir.o2;
            label33.Text = turSehir.o3;
            button1.Text = turSehir.b1;
            button2.Text = turSehir.b2;
            button7.Text = turSehir.b3;
            label40.Text = "* Seçmek zorunludur.";
            label41.Text = "* Seçmek zorunludur.";

            
            label42.Text = GırısAtama.kullanıcı;
            if ((label42.Text != GırısAtama.kullanıcı) || (GırısAtama.kullanıcı == "0"))
            {
                label42.Text = "Giriş Yapınız.";
                label42.ForeColor = Color.Maroon;
            }
            else
            {
                label42.Text = "HOŞGELDİN " + GırısAtama.kullanıcı;
                label42.ForeColor = Color.SeaGreen;
            }

           
            base3.Add(turSehir);

          
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;


           
            pictureBox5.ImageLocation = "tik.png";
            pictureBox6.ImageLocation = "rehber.png";
            pictureBox7.ImageLocation = "uçak.png";
            pictureBox8.ImageLocation = "tik.png";
            pictureBox9.ImageLocation = "rehber.png";
            pictureBox10.ImageLocation = "uçak.png";
            pictureBox11.ImageLocation = "tik.png";
            pictureBox12.ImageLocation = "rehber.png";
            pictureBox13.ImageLocation = "uçak.png";
            pictureBox14.ImageLocation = "tik.png";
            pictureBox15.ImageLocation = "rehber.png";
            pictureBox16.ImageLocation = "uçak.png";
            pictureBox17.ImageLocation = "baggage.png";
            pictureBox18.ImageLocation = "logo1.png";

            comboBox1.Items.Add("500-800 TL");
            comboBox1.Items.Add("900-1600 TL");
            comboBox1.Items.Add("1700-2500 TL");
            comboBox1.Items.Add("2600-3000 TL");
            comboBox1.Text = "Seçiniz...";

            
            button3.Text = TurIsmi.AKTUR.ToString();
            button4.Text = TurIsmi.ULUTUR.ToString();
            button5.Text = TurIsmi.ÖZTUR.ToString();
            button6.Text = TurIsmi.CANTUR.ToString();

           
            if (Atama.isim == "İstanbul")
            {
               
                base3.birim = atama.x;
               
                label34.Text = turSehir.x;
                label35.Text = turSehir.x;
                label36.Text = turSehir.x;
                label37.Text = turSehir.x;

               
                pictureBox1.ImageLocation = "istPic1.jpg";
                pictureBox2.ImageLocation = "istPic2.jpg";
                pictureBox3.ImageLocation = "istPic3.jpg";
                pictureBox4.ImageLocation = "istPic4.jpg";

              
                label7.Text = "Galata Kulesi";
                label8.Text = "Yıldız Parkı";
                label9.Text = "Topkapı Sarayı";
                label14.Text = "Kız Kulesi";
                label15.Text = "Miniatürk";
                label16.Text = "Pierre Loti Tepesi";
                label21.Text = "Boğaz Turu";
                label22.Text = "Kapalıçarşı";
                label23.Text = "Dolmabahçe Sarayı";
                label28.Text = "Heybeli Ada";
                label29.Text = "Büyük Çamlıca Tepesi";
                label30.Text = "Süleymaniye Cami";

                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.AKTUR); 
                    label6.Text = prd.Fiyat.ToString();
                    
                    turSehir.Fiyatlandırma(TurIsmi.ULUTUR);
                    label13.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.ÖZTUR);
                    label20.Text = prd.Fiyat.ToString();
                   
                    turSehir.Fiyatlandırma(TurIsmi.CANTUR);
                    label27.Text = prd.Fiyat.ToString();
                }
            
            }

        
            if (Atama.isim == "Antalya")
            {
                
                base3.birim = atama.x;

               
                label34.Text = turSehir.x;
                label35.Text = turSehir.x;
                label36.Text = turSehir.x;
                label37.Text = turSehir.x;


                pictureBox1.ImageLocation = "AntPic1.jpg";
                pictureBox2.ImageLocation = "AntPic2.jpg";
                pictureBox3.ImageLocation = "AntPic3.jpg";
                pictureBox4.ImageLocation = "AntPic4.jpg";


                label7.Text = "Aspendos Antik Kent";
                label8.Text = "Göynük";
                label9.Text = "Saklıkent";
                label14.Text = "Antalya Kalesi";
                label15.Text = "Olimpos";
                label16.Text = "Suluada";
                label21.Text = "Yassı Tepe";
                label22.Text = "Korsan Tekne";
                label23.Text = "Kemer";
                label28.Text = "Köprülü Kanyon";
                label29.Text = "Olimpos";
                label30.Text = "Aspendos Antik Kent";

               
                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.AKTUR);
                    label6.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.ULUTUR);
                    label13.Text = prd.Fiyat.ToString();


                    turSehir.Fiyatlandırma(TurIsmi.ÖZTUR);
                    label20.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.CANTUR);
                    label27.Text = prd.Fiyat.ToString();
                }
            }

       
            if (Atama.isim == "Nevşehir")
            {
                
                base3.birim = atama.x;

                
                label34.Text = turSehir.x;
                label35.Text = turSehir.x;
                label36.Text = turSehir.x;
                label37.Text = turSehir.x;

              
                pictureBox1.ImageLocation = "nevPic1.jpg";
                pictureBox2.ImageLocation = "nevPic2.jpg";
                pictureBox3.ImageLocation = "nevPic3.jpg";
                pictureBox4.ImageLocation = "nevPic4.jpg";

              
                label7.Text = "Kızılçukur Vadisi";
                label8.Text = "Avanos";
                label9.Text = "";
                label14.Text = "Güllüdere Vadisi";
                label15.Text = "Galerie İkman";
                label16.Text = "";
                label21.Text = "Güvercinlik Vadisi";
                label22.Text = "Kaya Kamp";
                label23.Text = "";
                label28.Text = "Kızılırmak";
                label29.Text = "Avanos";
                label30.Text = "";

              
                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.AKTUR);
                    label6.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.ULUTUR);
                    label13.Text = prd.Fiyat.ToString();


                    turSehir.Fiyatlandırma(TurIsmi.ÖZTUR);
                    label20.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.CANTUR);
                    label27.Text = prd.Fiyat.ToString();
                }


            }

        
            if (Atama.isim == "Mardin")
            {
                
                base3.birim = atama.x;

               
                label34.Text = turSehir.x;
                label35.Text = turSehir.x;
                label36.Text = turSehir.x;
                label37.Text = turSehir.x;

              
                pictureBox1.ImageLocation = "marPic1.jpg";
                pictureBox2.ImageLocation = "marPic2.jpg";
                pictureBox3.ImageLocation = "marPic3.jpg";
                pictureBox4.ImageLocation = "marPic4.jpg";

                label7.Text = "Gurs Vadisi";
                label8.Text = "Beyazsu";
                label9.Text = "";
                label14.Text = "Midyat";
                label15.Text = "Kayseriye Çarşısı";
                label16.Text = "";
                label21.Text = "Midyat";
                label22.Text = "Turabdin Platosu";
                label23.Text = "";
                label28.Text = "Kilit Köyü";
                label29.Text = "Hasankeyf";
                label30.Text = "";

               
                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.AKTUR);
                    label6.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.ULUTUR);
                    label13.Text = prd.Fiyat.ToString();


                    turSehir.Fiyatlandırma(TurIsmi.ÖZTUR);
                    label20.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.CANTUR);
                    label27.Text = prd.Fiyat.ToString();
                }
            }

          
            if (Atama.isim == "Trabzon")
            {
              
                base3.birim = atama.x;

              
                label34.Text = turSehir.x;
                label35.Text = turSehir.x;
                label36.Text = turSehir.x;
                label37.Text = turSehir.x;

            
                pictureBox1.ImageLocation = "trabPic1.jpg";
                pictureBox2.ImageLocation = "trabPic2.jpg";
                pictureBox3.ImageLocation = "trabPic3.jpg";
                pictureBox4.ImageLocation = "trabPic4.jpg";

               
                label7.Text = "Atatürk Köşkü";
                label8.Text = "Maçka";
                label9.Text = "Çamburnu Parkı";
                label14.Text = "Uzungöl";
                label15.Text = "Karester Yaylası";
                label16.Text = "Çal Mağarası";
                label21.Text = "Os Şelalesi";
                label22.Text = "Beşikdüzü Teleferik";
                label23.Text = "Külindağı";
                label28.Text = "Sümela Manastırı";
                label29.Text = "Akçaabat";
                label30.Text = "Şahinkaya";

            
                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.AKTUR);
                    label6.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.ULUTUR);
                    label13.Text = prd.Fiyat.ToString();


                    turSehir.Fiyatlandırma(TurIsmi.ÖZTUR);
                    label20.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.CANTUR);
                    label27.Text = prd.Fiyat.ToString();
                }

            }

            if (Atama.isim == "Ankara")
            {
                
                base3.birim = atama.x;

               
                label34.Text = turSehir.x;
                label35.Text = turSehir.x;
                label36.Text = turSehir.x;
                label37.Text = turSehir.x;

              
                pictureBox1.ImageLocation = "ankPic1.jpg";
                pictureBox2.ImageLocation = "ankPic2.jpg";
                pictureBox3.ImageLocation = "ankPic3.jpg";
                pictureBox4.ImageLocation = "ankPic4.jpg";

                label7.Text = "Elmadağ";
                label8.Text = "Oyuncak Müzesi";
                label9.Text = "50. Yıl Parkı";
                label14.Text = "Anıtkabir";
                label15.Text = "Atatürk Orman Çiftliği";
                label16.Text = "Nallıhan Kuş Cenneti";
                label21.Text = "Sorgun Göleti";
                label22.Text = "Tekke Dağı";
                label23.Text = "Mavi Göl";
                label28.Text = "Ankara Kalesi";
                label29.Text = "Tuz Gölü";
                label30.Text = "Eğriova Yaylası";

                
                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.AKTUR);
                    label6.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.ULUTUR);
                    label13.Text = prd.Fiyat.ToString();


                    turSehir.Fiyatlandırma(TurIsmi.ÖZTUR);
                    label20.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.CANTUR);
                    label27.Text = prd.Fiyat.ToString();
                }

            }

          
            if (Atama.isim == "Almanya")
            {
               
                base3.birim = atama.y;

                label34.Text = turSehir.y;
                label35.Text = turSehir.y;
                label36.Text = turSehir.y;
                label37.Text = turSehir.y;

                comboBox1.Items.Clear();

                comboBox1.Items.Add("500-800 EURO");
                comboBox1.Items.Add("900-1600 EURO");
                comboBox1.Items.Add("1700-2500 EURO");
                comboBox1.Items.Add("2600-3000 EURO");
                comboBox1.Text = "Seçiniz...";

                button3.Text = TurIsmi.BIGTOUR.ToString();
                button4.Text = TurIsmi.TRIOTOUR.ToString();
                button5.Text = TurIsmi.REDTOUR.ToString();
                button6.Text = TurIsmi.ASIATOUR.ToString();

              
                pictureBox1.ImageLocation = "almPic1.jpg";
                pictureBox2.ImageLocation = "almPic2.jpg";
                pictureBox3.ImageLocation = "almPic3.jpg";
                pictureBox4.ImageLocation = "almPic4.jpg";

             
                label7.Text = "Kara Orman";
                label8.Text = "Rothenburg";
                label9.Text = "Regnitz Vadisi";
                label14.Text = "Masal Kalesi";
                label15.Text = "Potsdamer Meydanı";
                label16.Text = "Salzburg";
                label21.Text = "Ren Vadisi";
                label22.Text = "Müze Adası";
                label23.Text = "Köln Katedrali";
                label28.Text = "Çiçek Adası";
                label29.Text = "Berlin Duvarı";
                label30.Text = "Bavyera Gölü";

             
                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.BIGTOUR);
                    label6.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.TRIOTOUR);
                    label13.Text = prd.Fiyat.ToString();


                    turSehir.Fiyatlandırma(TurIsmi.REDTOUR);
                    label20.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.ASIATOUR);
                    label27.Text = prd.Fiyat.ToString();
                }
            }

            
            if (Atama.isim == "Arjantin")
            {
                
                base3.birim = atama.z;

              
                label34.Text = turSehir.z;
                label35.Text = turSehir.z;
                label36.Text = turSehir.z;
                label37.Text = turSehir.z;

                comboBox1.Items.Clear();

                comboBox1.Items.Add("500-800 ARS");
                comboBox1.Items.Add("900-1600 ARS");
                comboBox1.Items.Add("1700-2500 ARS");
                comboBox1.Items.Add("2600-3000 ARS");
                comboBox1.Text = "Seçiniz...";

                
                button3.Text = TurIsmi.BIGTOUR.ToString();
                button4.Text = TurIsmi.TRIOTOUR.ToString();
                button5.Text = TurIsmi.REDTOUR.ToString();
                button6.Text = TurIsmi.ASIATOUR.ToString();
              
                pictureBox1.ImageLocation = "arjPic1.jpg";
                pictureBox2.ImageLocation = "arjPic2.jpg";
                pictureBox3.ImageLocation = "arjPic3.jpg";
                pictureBox4.ImageLocation = "arjPic4.jpg";

               
                label7.Text = "Delta Tigre";
                label8.Text = "Malba";
                label9.Text = "Ulusal Bayrak Anıtı";
                label14.Text = "San Ignacio Mini";
                label15.Text = "Aconcagua Dağı";
                label16.Text = "Cacheuta Spa";
                label21.Text = "Iguazu Şelalesi";
                label22.Text = "Buenos Aires Dikilitaşı";
                label23.Text = "Nahuel Huapi Gölü";
                label28.Text = "Pilar Kilisesi";
                label29.Text = "Los Glaciares Buzulları";
                label30.Text = "Mar Chiquita";

              
                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.BIGTOUR);
                    label6.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.TRIOTOUR);
                    label13.Text = prd.Fiyat.ToString();


                    turSehir.Fiyatlandırma(TurIsmi.REDTOUR);
                    label20.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.ASIATOUR);
                    label27.Text = prd.Fiyat.ToString();
                }

            }

           
            if (Atama.isim == "İtalya")
            {
               
                base3.birim = atama.y;

             
                label34.Text = turSehir.y;
                label35.Text = turSehir.y;
                label36.Text = turSehir.y;
                label37.Text = turSehir.y;

                comboBox1.Items.Clear();

                comboBox1.Items.Add("500-800 EURO");
                comboBox1.Items.Add("900-1600 EURO");
                comboBox1.Items.Add("1700-2500 EURO");
                comboBox1.Items.Add("2600-3000 EURO");
                comboBox1.Text = "Seçiniz...";

           
                button3.Text = TurIsmi.BIGTOUR.ToString();
                button4.Text = TurIsmi.TRIOTOUR.ToString();
                button5.Text = TurIsmi.REDTOUR.ToString();
                button6.Text = TurIsmi.ASIATOUR.ToString();

                
                pictureBox1.ImageLocation = "italPic1.jpg";
                pictureBox2.ImageLocation = "italPic2.jpg";
                pictureBox3.ImageLocation = "italPic3.jpg";
                pictureBox4.ImageLocation = "italPic4.jpg";

              
                label7.Text = "Pisa Kulesi";
                label8.Text = "Duomo Katedrali";
                label9.Text = "Capitol Tepesi";
                label14.Text = "Collesium";
                label15.Text = "Pantheon Tapınağı";
                label16.Text = "Como Gölü";
                label21.Text = "Venedik";
                label22.Text = "İkiz Kuleler";
                label23.Text = "Trevi Çeşmesi";
                label28.Text = "Mavi Mağara";
                label29.Text = "Tiber Nehri";
                label30.Text = "Roma Forumu";

               
                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.BIGTOUR);
                    label6.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.TRIOTOUR);
                    label13.Text = prd.Fiyat.ToString();


                    turSehir.Fiyatlandırma(TurIsmi.REDTOUR);
                    label20.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.ASIATOUR);
                    label27.Text = prd.Fiyat.ToString();
                }
            }

        
            if (Atama.isim == "Japonya")
            {
                
                base3.birim = atama.k;

             
                label34.Text = turSehir.k;
                label35.Text = turSehir.k;
                label36.Text = turSehir.k;
                label37.Text = turSehir.k;

              
                comboBox1.Items.Clear();

                comboBox1.Items.Add("500000-800000 YEN");
                comboBox1.Items.Add("900000-1600000 YEN");
                comboBox1.Items.Add("1700000-2500000 YEN");
                comboBox1.Items.Add("2600000-3000000 YEN");
                comboBox1.Text = "Seçiniz...";


               
                button3.Text = TurIsmi.ASIANTOUR.ToString();
                button4.Text = TurIsmi.IKURATOUR.ToString();
                button5.Text = TurIsmi.ARIGATOUR.ToString();
                button6.Text = TurIsmi.AWARETOUR.ToString();

              
                pictureBox1.ImageLocation = "japPic1.jpg";
                pictureBox2.ImageLocation = "japPic2.jpg";
                pictureBox3.ImageLocation = "japPic3.jpg";
                pictureBox4.ImageLocation = "japPic4.jpg";

             
                label7.Text = "Fuji Dağı";
                label8.Text = "Senso Ji Tapınağı";
                label9.Text = "Skytree Kulesi";
                label14.Text = "Osaka Kalesi";
                label15.Text = "İmparatorluk Sarayı";
                label16.Text = "Araşiyama Ormanı";
                label21.Text = "Ueno Parkı";
                label22.Text = "Japonya Ulusal Müzesi";
                label23.Text = "Himeji Kalesi";
                label28.Text = "Urnes Stave Kilisesi";
                label29.Text = "Kawaguchi Gölü";
                label30.Text = "Ashi Gölü";

               
                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.ASIANTOUR);
                    label6.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.IKURATOUR);
                    label13.Text = prd.Fiyat.ToString();


                    turSehir.Fiyatlandırma(TurIsmi.ARIGATOUR);
                    label20.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.AWARETOUR);
                    label27.Text = prd.Fiyat.ToString();
                }

            }

            
            if (Atama.isim == "Norveç")
            {
              
                base3.birim = atama.t;

                
                label34.Text = turSehir.t;
                label35.Text = turSehir.t;
                label36.Text = turSehir.t;
                label37.Text = turSehir.t;

              
                comboBox1.Items.Clear();

                comboBox1.Items.Add("500-800 KRON");
                comboBox1.Items.Add("900-1600 KRON");
                comboBox1.Items.Add("1700-2500 KRON");
                comboBox1.Items.Add("2600-3000 KRON");
                comboBox1.Text = "Seçiniz...";

                button3.Text = TurIsmi.BIGTOUR.ToString();
                button4.Text = TurIsmi.TRIOTOUR.ToString();
                button5.Text = TurIsmi.REDTOUR.ToString();
                button6.Text = TurIsmi.ASIATOUR.ToString();

              
                pictureBox1.ImageLocation = "norPic1.jpg";
                pictureBox2.ImageLocation = "norPic2.jpg";
                pictureBox3.ImageLocation = "norPic3.jpg";
                pictureBox4.ImageLocation = "norPic4.jpg";

              
                label7.Text = "Lyse Fjord";
                label8.Text = "Lofoten Adası";
                label9.Text = "Seven Sisters Şelalesi";
                label14.Text = "Oscarborg Kalesi";
                label15.Text = "Vigeland Heykel Parkı";
                label16.Text = "Geiranger Köyü";
                label21.Text = "Preikestolen";
                label22.Text = "Bryggen Evleri";
                label23.Text = "Akeshuh Kalesi";
                label28.Text = "Oslo Opera Binası";
                label29.Text = "Nideros Katedrali";
                label30.Text = "Viking Gemi Müzesi";

               
                foreach (var prd in base3.GetAtama())
                {
                    turSehir.Fiyatlandırma(TurIsmi.BIGTOUR);
                    label6.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.TRIOTOUR);
                    label13.Text = prd.Fiyat.ToString();


                    turSehir.Fiyatlandırma(TurIsmi.REDTOUR);
                    label20.Text = prd.Fiyat.ToString();

                    turSehir.Fiyatlandırma(TurIsmi.ASIATOUR);
                    label27.Text = prd.Fiyat.ToString();
                }

            }

        }


    
        Odeme odeme = new Odeme();
        public String click = "tur";
        public int days;
        public double tarihler;
        
        private void button3_Click(object sender, EventArgs e)
        {
            base3.click3 = click;

            turSehir.Fiyat = Convert.ToInt32(label6.Text);

            TimeSpan turkatılım = dateTimePicker2.Value - dateTimePicker1.Value;

            tarihler = turkatılım.TotalDays;

            days = Convert.ToInt32(tarihler);

            Sepet.günsayisitur = days;

            turSehir.gonder(button3.Text, turSehir.Fiyat, Convert.ToInt32(textBox2.Text), days);

            Sepet.günlükfiyattur = turSehir.Fiyat.ToString();
            Sepet.kisisayisitur = textBox2.Text;
            Sepet.turisim = turSehir.tur;
            admingiris2.turkisi = textBox2.Text;


            turSehir.Hesap();  
            Sepet.turtoplam = turSehir.toplamt.ToString();
            admingiris2.turtoplami = turSehir.toplamt.ToString();

            turSehir.Fiyat = turSehir.toplamt;

            Sepet.total = base3.TotalPrice();
            MessageBox.Show("Seçiminiz Sepete Eklenmiştir.");
            

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            odeme.click3 = click;

            turSehir.Fiyat = Convert.ToInt32(label13.Text);

            TimeSpan turkatılım = dateTimePicker2.Value - dateTimePicker1.Value;

            tarihler = turkatılım.TotalDays;

            days = Convert.ToInt32(tarihler);

            Sepet.günsayisitur = days;

            turSehir.gonder(button4.Text, turSehir.Fiyat, Convert.ToInt32(textBox2.Text),days);


            Sepet.günlükfiyattur = turSehir.Fiyat.ToString();
            Sepet.kisisayisitur = textBox2.Text;
            Sepet.turisim = turSehir.tur;
            admingiris2.turkisi = textBox2.Text;


            turSehir.Hesap();
            Sepet.turtoplam = turSehir.toplamt.ToString();
            admingiris2.turtoplami = turSehir.toplamt.ToString();

            turSehir.Fiyat = turSehir.toplamt;
            
            Sepet.total = base3.TotalPrice();
            MessageBox.Show("Seçiminiz Sepete Eklenmiştir.");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            odeme.click3 = click;
            turSehir.Fiyat = Convert.ToInt32(label20.Text);

            TimeSpan turkatılım = dateTimePicker2.Value - dateTimePicker1.Value;

            tarihler = turkatılım.TotalDays;

            days = Convert.ToInt32(tarihler);

            Sepet.günsayisitur = days;

            turSehir.gonder(button5.Text, turSehir.Fiyat, Convert.ToInt32(textBox2.Text),days);


            Sepet.günlükfiyattur = turSehir.Fiyat.ToString();
            Sepet.kisisayisitur = textBox2.Text;
            Sepet.turisim = turSehir.tur;
            admingiris2.turkisi = textBox2.Text;


            turSehir.Hesap();
            admingiris2.turtoplami = turSehir.toplamt.ToString();
            Sepet.turtoplam = turSehir.toplamt.ToString();

            turSehir.Fiyat = turSehir.toplamt;

            Sepet.total = base3.TotalPrice();
            MessageBox.Show("Seçiminiz Sepete Eklenmiştir.");
           
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            odeme.click3 = click;
            turSehir.Fiyat = Convert.ToInt32(label27.Text);

            TimeSpan turkatılım = dateTimePicker2.Value - dateTimePicker1.Value;

            tarihler = turkatılım.TotalDays;

            days = Convert.ToInt32(tarihler);

            Sepet.günsayisitur = days;

            turSehir.gonder(button6.Text, turSehir.Fiyat, Convert.ToInt32(textBox2.Text),days);

            Sepet.günlükfiyattur = turSehir.Fiyat.ToString();
            Sepet.kisisayisitur = textBox2.Text;
            Sepet.turisim = turSehir.tur;
            admingiris2.turkisi = textBox2.Text;

            admingiris2.turtoplami = turSehir.toplamt.ToString();
            turSehir.Hesap();
            Sepet.turtoplam = turSehir.toplamt.ToString();

            turSehir.Fiyat = turSehir.toplamt;

            Sepet.total = base3.TotalPrice();
            MessageBox.Show("Seçiminiz Sepete Eklenmiştir.");
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "500-800 TL") || (comboBox1.Text == "500-800 EURO") || (comboBox1.Text == "500-800 KRON") || (comboBox1.Text == "500000-800000 YEN") || (comboBox1.Text == "500-800 ARS"))
            {
                panel1.BackColor = Color.DarkGray;
                label6.ForeColor = Color.White;
                label6.BackColor = Color.Green;

            }

            if ((comboBox1.Text == "900-1600 TL") || (comboBox1.Text == "900-1600 EURO") || (comboBox1.Text == "900-1600 KRON") || (comboBox1.Text == "900000-1600000 YEN") || (comboBox1.Text == "900-1600 ARS"))
            {

                panel2.BackColor = Color.DarkGray;
                label13.ForeColor = Color.White;
                label13.BackColor = Color.Green;
            }

            if ((comboBox1.Text == "1700-2500 TL") || (comboBox1.Text == "1700-2500 EURO") || (comboBox1.Text == "1700-2500 KRON") || (comboBox1.Text == "1700000-2500000 YEN") || (comboBox1.Text == "1700-2500 ARS"))
            {

                panel3.BackColor = Color.DarkGray;
                label20.ForeColor = Color.White;
                label20.BackColor = Color.Green;
            }

            if ((comboBox1.Text == "2600-3000 TL") || (comboBox1.Text == "2600-3000 EURO") || (comboBox1.Text == "2600-3000 KRON") || (comboBox1.Text == "2600000-3000000 YEN") || (comboBox1.Text == "2600-3000 ARS"))
            {
                panel4.BackColor = Color.DarkGray;
                label27.ForeColor = Color.White;
                label27.BackColor = Color.Green;
            }
        }

 
        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = "Seçiniz...";

            panel1.BackColor = Color.Silver;
            panel2.BackColor = Color.Silver;
            panel3.BackColor = Color.Silver;
            panel4.BackColor = Color.Silver;


            label6.ForeColor = Color.Black;
            label6.BackColor = Color.Silver;

            label13.ForeColor = Color.Black;
            label13.BackColor = Color.Silver;

            label20.ForeColor = Color.Black;
            label20.BackColor = Color.Silver;

            label27.ForeColor = Color.Black;
            label27.BackColor = Color.Silver;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            odeme.Show();
        }

        private void katalogSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Katalog katalog = new Katalog();
            this.Hide();
            katalog.Show();
        }

        private void müzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Muze muze = new Muze();
            this.Hide();
            muze.Show();
        }

        private void konaklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otel otel = new Otel();
            this.Hide();
            otel.Show();
        }

        private void kayıtOlunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitsayfasi yeni = new kayitsayfasi();
            yeni.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void şehirlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void katalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restoranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustripten restoran seçeneği seçilirse o sayfaya geçiş yapar.
            Restoran reestoran = new Restoran();
            this.Hide();
            reestoran.Show();
        }

        private void turToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ulaşımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ULASIM ulaşım = new ULASIM();
            
            this.Hide();
            ulaşım.Show();

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

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void girişYapınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            girisYapin giris = new girisYapin();
            this.Hide();
            giris.Show();
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }
    }
}
