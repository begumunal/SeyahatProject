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
    public partial class Otel : Form
    {
        public Otel()
        {
            InitializeComponent();
        }

     
        OtelSehir otelsehir = new OtelSehir();
        Sepet sepet = new Sepet();
        Odeme odeme = new Odeme();
       
        Atama atama = new OtelSehir();

       
        private void Otel_Load(object sender, EventArgs e)
        {
            Atama.kategori = "Otel";

            this.AutoScroll = true; 
            this.MaximizeBox = false;
            label1.Text = otelsehir.sehir;

          
            groupBox1.Text = "Seçim:";
            label2.Text = "Bütçe:";
            label3.Text = "Kişi Sayısı:";
            label4.Text = "Giriş Tarihi:";
            label5.Text = "Çıkış Tarihi:";
            button1.Text = "Sırala";
            button2.Text = "Temizle";
            button3.Text = "Sepete Ekle";
            button4.Text = "Ödeme";
            label54.Text = "* Seçmek zorunludur.";
            label55.Text = "* Seçmek zorunludur.";
            
          
            label56.Text = GırısAtama.kullanıcı;
            if((label56.Text!=GırısAtama.kullanıcı) || (GırısAtama.kullanıcı == "0"))
            {
                label56.Text = "Giriş Yapınız.";
                label56.ForeColor = Color.Maroon;
            }
            else
            {
                label56.Text = "HOŞGELDİN " + GırısAtama.kullanıcı;
                label56.ForeColor = Color.SeaGreen;
            }


            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");

           
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox33.ImageLocation = "logo1.png";
            pictureBox34.ImageLocation = "bell.png";

       
            sepet.Add(otelsehir);

      
            if (otelsehir.sehir == "İstanbul")
            {
                
                sepet.birim = atama.x; 
               
                label8.Text = otelsehir.x;
                label12.Text = otelsehir.x;
                label18.Text = otelsehir.x;
                label24.Text = otelsehir.x;
                label30.Text = otelsehir.x;
                label37.Text = otelsehir.x;
                label42.Text = otelsehir.x;
                label48.Text = otelsehir.x;

                pictureBox1.ImageLocation = "lavanta hotel.jpg";
                pictureBox2.ImageLocation = "royal inci airport hotel.jpg";
                pictureBox3.ImageLocation = "beyaz kosk hotel.jpg";
                pictureBox8.ImageLocation = "tempo hotel.png";
                pictureBox4.ImageLocation = "divan istanbul otel.jpg";
                pictureBox5.ImageLocation = "doubletree.jpg";
                pictureBox6.ImageLocation = "swissotel.jpg";
                pictureBox7.ImageLocation = "peraotel.jpg";

                radioButton1.Text = Otelismi.LavantaOtel.ToString();
                radioButton2.Text = Otelismi.RoyalInciAirportHotel.ToString();
                radioButton3.Text = Otelismi.BeyazKöşkOtel.ToString();
                radioButton4.Text = Otelismi.TempoOtel.ToString();
                radioButton5.Text = Otelismi.DivanIstanbulOtel.ToString();
                radioButton6.Text = Otelismi.DoubletreeByHiltonIstanbulOtel.ToString();
                radioButton7.Text = Otelismi.SwissotelTheBosphorus.ToString();
                radioButton8.Text = Otelismi.PeraPalaceHotel.ToString();

   
                foreach (var prd in sepet.GetAtama())
                {
                   
                    otelsehir.otelisim(Otelismi.LavantaOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label7.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.RoyalInciAirportHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label13.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.BeyazKöşkOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label19.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.TempoOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label25.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.DivanIstanbulOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label31.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.DoubletreeByHiltonIstanbulOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.SwissotelTheBosphorus); 
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label43.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.PeraPalaceHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label49.Text = prd.Fiyat.ToString();

                 
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }


            if (otelsehir.sehir == "Trabzon")
            {
                
                sepet.birim = atama.x;
               
                label8.Text = otelsehir.x;
                label12.Text = otelsehir.x;
                label18.Text = otelsehir.x;
                label24.Text = otelsehir.x;
                label30.Text = otelsehir.x;
                label37.Text = otelsehir.x;
                label42.Text = otelsehir.x;
                label48.Text = otelsehir.x;

                pictureBox1.ImageLocation = "arsen otel.jpg";
                pictureBox2.ImageLocation = "holiday otel.jpg";
                pictureBox3.ImageLocation = "grand vaves otel.jpg";
                pictureBox8.ImageLocation = "aselia hotel.jpg";
                pictureBox4.ImageLocation = "Zitas otel zigana.jpg";
                pictureBox5.ImageLocation = "park dedeman otel.jpg";
                pictureBox6.ImageLocation = "radisson blu otel.jpg";
                pictureBox7.ImageLocation = "royal comfort hotel.jpg";

                radioButton1.Text = Otelismi.ArsenOtel.ToString();
                radioButton2.Text = Otelismi.UzungölHolidayOtel.ToString();
                radioButton3.Text = Otelismi.GrandVavesOtel.ToString();
                radioButton4.Text = Otelismi.AseliaHotel.ToString();
                radioButton5.Text = Otelismi.ZitasOtelZiganaYaylaTatilKöyü.ToString();
                radioButton6.Text = Otelismi.ParkDedemanOtel.ToString();
                radioButton7.Text = Otelismi.RadissonBluHotel.ToString();
                radioButton8.Text = Otelismi.RoyalComfortHotel.ToString();

            
                foreach (var prd in sepet.GetAtama())
                {
                   
                    otelsehir.otelisim(Otelismi.ArsenOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label7.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.UzungölHolidayOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label13.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.GrandVavesOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label19.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.AseliaHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label25.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.ZitasOtelZiganaYaylaTatilKöyü);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label31.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.ParkDedemanOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.RadissonBluHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label43.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.RoyalComfortHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label49.Text = prd.Fiyat.ToString();

                
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (Atama.isim == "Antalya")
            {
               
                sepet.birim = atama.x;
              
                label8.Text = otelsehir.x;
                label12.Text = otelsehir.x;
                label18.Text = otelsehir.x;
                label24.Text = otelsehir.x;
                label30.Text = otelsehir.x;
                label37.Text = otelsehir.x;
                label42.Text = otelsehir.x;
                label48.Text = otelsehir.x;

             
                pictureBox1.ImageLocation = "niss lara hotel.jpg";
                pictureBox2.ImageLocation = "sherwood prize otel.jpg";
                pictureBox3.ImageLocation = "akra v hotel.jpg";
                pictureBox8.ImageLocation = "the corner park hotel.jpg";
                pictureBox4.ImageLocation = "melda palace.jpg";
                pictureBox5.ImageLocation = "rixos downtown.jpg";
                pictureBox6.ImageLocation = "limak lara hotel.jpg";
                pictureBox7.ImageLocation = "the marmara.jpg";

              
                radioButton1.Text = Otelismi.NissLaraHotel.ToString();
                radioButton2.Text = Otelismi.SherwoodPrizeHotel.ToString();
                radioButton3.Text = Otelismi.AkraVHotel.ToString();
                radioButton4.Text = Otelismi.TheCornerParkHotel.ToString();
                radioButton5.Text = Otelismi.MeldaPalaceHotel.ToString();
                radioButton6.Text = Otelismi.RixosDowntownAntalya.ToString();
                radioButton7.Text = Otelismi.LimakLaraDeluxeHotel.ToString();
                radioButton8.Text = Otelismi.TheMarmaraAntalya.ToString();

               
                foreach (var prd in sepet.GetAtama())
                {
    
                    otelsehir.otelisim(Otelismi.NissLaraHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label7.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.SherwoodPrizeHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label13.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.AkraVHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label19.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.TheCornerParkHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label25.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.MeldaPalaceHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label31.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.RixosDowntownAntalya);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.LimakLaraDeluxeHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label43.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.TheMarmaraAntalya);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label49.Text = prd.Fiyat.ToString();

         
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (Atama.isim == "Ankara")
            {
                
                sepet.birim = atama.x;
               
                label8.Text = otelsehir.x;
                label12.Text = otelsehir.x;
                label18.Text = otelsehir.x;
                label24.Text = otelsehir.x;
                label30.Text = otelsehir.x;
                label37.Text = otelsehir.x;
                label42.Text = otelsehir.x;
                label48.Text = otelsehir.x;

               
                pictureBox1.ImageLocation = "hoteliçkale.jpeg";
                pictureBox2.ImageLocation = "thegreenpark.jpg";
                pictureBox3.ImageLocation = "bestwesternhotel.jpg";
                pictureBox8.ImageLocation = "ataköşkhotel.jpg";
                pictureBox4.ImageLocation = "warwickhotel.jpg";
                pictureBox5.ImageLocation = "ankarahilton.jpg";
                pictureBox6.ImageLocation = "Cp Ankara Hotel.jpg";
                pictureBox7.ImageLocation = "new park hotel.jpg";

                radioButton1.Text = Otelismi.HotelİçKale.ToString();
                radioButton2.Text = Otelismi.TheGreenParkOtel.ToString();
                radioButton3.Text = Otelismi.BestWesternHotel.ToString();
                radioButton4.Text = Otelismi.AtaköşkHotel.ToString();
                radioButton5.Text = Otelismi.WarwickOtel.ToString();
                radioButton6.Text = Otelismi.AnkaraHiltonOtel.ToString();
                radioButton7.Text = Otelismi.CPAnkaraHotel.ToString();
                radioButton8.Text = Otelismi.NewParkHotel.ToString();

             
                foreach (var prd in sepet.GetAtama())
                {
                   
                    otelsehir.otelisim(Otelismi.HotelİçKale);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label7.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.TheGreenParkOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label13.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.BestWesternHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label19.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.AtaköşkHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label25.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.WarwickOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label31.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.AnkaraHiltonOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.CPAnkaraHotel); 
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label43.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.NewParkHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label49.Text = prd.Fiyat.ToString();

                  
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (Atama.isim == "Nevşehir")
            {
              
                sepet.birim = atama.x;
                
                label8.Text = otelsehir.x;
                label12.Text = otelsehir.x;
                label18.Text = otelsehir.x;
                label24.Text = otelsehir.x;
                label30.Text = otelsehir.x;
                label37.Text = otelsehir.x;
                label42.Text = otelsehir.x;
                label48.Text = otelsehir.x;

            
                pictureBox1.ImageLocation = "Göreme Reva Hotel.jpg";
                pictureBox2.ImageLocation = "has cave konak.jpg";
                pictureBox3.ImageLocation = "elif stone house.jpg";
                pictureBox8.ImageLocation = "sofa hotel.jpg";
                pictureBox4.ImageLocation = "dedeli deluxe hotel.jpg";
                pictureBox5.ImageLocation = "the village cave hotel.jpg";
                pictureBox6.ImageLocation = "taşkonaklar otel.jpg";
                pictureBox7.ImageLocation = "dere suites.jpg";

               
                radioButton1.Text = Otelismi.GöremeRevaHotel.ToString();
                radioButton2.Text = Otelismi.HasCaveKonakÜrgüp.ToString();
                radioButton3.Text = Otelismi.ElifStoneHouse.ToString();
                radioButton4.Text = Otelismi.SofaHotel.ToString();
                radioButton5.Text = Otelismi.DedeliDeluxeHotel.ToString();
                radioButton6.Text = Otelismi.TheVillageCaveHotel.ToString();
                radioButton7.Text = Otelismi.TaşkonaklarOtel.ToString();
                radioButton8.Text = Otelismi.DereSuites.ToString();

                
                foreach (var prd in sepet.GetAtama())
                {
                   
                    otelsehir.otelisim(Otelismi.GöremeRevaHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label7.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HasCaveKonakÜrgüp);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label13.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.ElifStoneHouse);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label19.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.SofaHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label25.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.DedeliDeluxeHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label31.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.TheVillageCaveHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.TaşkonaklarOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label43.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.DereSuites);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label49.Text = prd.Fiyat.ToString();

                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }
            if (Atama.isim == "Mardin")
            {
               
                sepet.birim = atama.x;
                          
                label8.Text = otelsehir.x;
                label12.Text = otelsehir.x;
                label18.Text = otelsehir.x;
                label24.Text = otelsehir.x;
                label30.Text = otelsehir.x;
                label37.Text = otelsehir.x;
                label42.Text = otelsehir.x;
                label48.Text = otelsehir.x;

             
                pictureBox1.ImageLocation = "tuğhan otel.jpg";
                pictureBox2.ImageLocation = "Dara Konağı.jpg";
                pictureBox3.ImageLocation = "mardin osmanlı konağı.jpg";
                pictureBox8.ImageLocation = "maristan tarihi konak.jpg";
                pictureBox4.ImageLocation = "maridin otel.jpg";
                pictureBox5.ImageLocation = "Hilton Garden Inn Mardin.jpg";
                pictureBox6.ImageLocation = "ramada plaza mardin.jpg";
                pictureBox7.ImageLocation = "mardius tarihi konak.jpg";

              
                radioButton1.Text = Otelismi.TuğhanOtel.ToString();
                radioButton2.Text = Otelismi.DaraKonağı.ToString();
                radioButton3.Text = Otelismi.MardinOsmanlıKonağı.ToString();
                radioButton4.Text = Otelismi.MaristanTarihiKonak.ToString();
                radioButton5.Text = Otelismi.MaridinOtel.ToString();
                radioButton6.Text = Otelismi.HiltonGardenInnMardin.ToString();
                radioButton7.Text = Otelismi.RamadaPlazaByWyndhamMardin.ToString();
                radioButton8.Text = Otelismi.MardiusTarihiKonakOtel.ToString();

            
                foreach (var prd in sepet.GetAtama())
                {
                   
                    otelsehir.otelisim(Otelismi.TuğhanOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label7.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.DaraKonağı);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label13.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.MardinOsmanlıKonağı);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label19.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.MaristanTarihiKonak);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label25.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.MaridinOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label31.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HiltonGardenInnMardin);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.RamadaPlazaByWyndhamMardin);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label43.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.MardiusTarihiKonakOtel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label49.Text = prd.Fiyat.ToString();

                    
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (Atama.isim == "Almanya")
            {
               
                sepet.birim = atama.y;
               
                label8.Text = otelsehir.y;
                label12.Text = otelsehir.y;
                label18.Text = otelsehir.y;
                label24.Text = otelsehir.y;
                label30.Text = otelsehir.y;
                label37.Text = otelsehir.y;
                label42.Text = otelsehir.y;
                label48.Text = otelsehir.y;

               
                pictureBox1.ImageLocation = "intercity hotel.jpg";
                pictureBox2.ImageLocation = "centro hotel.jpg";
                pictureBox3.ImageLocation = "leonardo hotel hannover.jpg";
                pictureBox8.ImageLocation = "maritim hotel ulm.jpg";
                pictureBox4.ImageLocation = "hotel loccumer hof.jpg";
                pictureBox5.ImageLocation = "hilton dresden.jpg";
                pictureBox6.ImageLocation = "excelsior hotel.jpg";
                pictureBox7.ImageLocation = "steigenberger hotel.jpg";

               
                radioButton1.Text = Otelismi.İntercityHotel.ToString();
                radioButton2.Text = Otelismi.CentroHotelStadtGütersloh.ToString();
                radioButton3.Text = Otelismi.LeonardoHotelHannover.ToString();
                radioButton4.Text = Otelismi.MaritimHotelUlm.ToString();
                radioButton5.Text = Otelismi.HotelLoccumerHof.ToString();
                radioButton6.Text = Otelismi.HiltonDresden.ToString();
                radioButton7.Text = Otelismi.ExcelsiorHotel.ToString();
                radioButton8.Text = Otelismi.SteigenbergerHotel.ToString();

               
                foreach (var prd in sepet.GetAtama())
                {
                    
                    otelsehir.otelisim(Otelismi.İntercityHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label7.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.CentroHotelStadtGütersloh);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label13.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.LeonardoHotelHannover);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label19.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.MaritimHotelUlm);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label25.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HotelLoccumerHof);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label31.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HiltonDresden);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.ExcelsiorHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label43.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.SteigenbergerHotel); 
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label49.Text = prd.Fiyat.ToString();

                   
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (Atama.isim == "İtalya")
            {
               
                sepet.birim = atama.y;
               
                label8.Text = otelsehir.y;
                label12.Text = otelsehir.y;
                label18.Text = otelsehir.y;
                label24.Text = otelsehir.y;
                label30.Text = otelsehir.y;
                label37.Text = otelsehir.y;
                label42.Text = otelsehir.y;
                label48.Text = otelsehir.y;

               
                pictureBox1.ImageLocation = "hotel vienna.jpg";
                pictureBox2.ImageLocation = "corte san mattia.jpg";
                pictureBox3.ImageLocation = "hotel fonte.jpg";
                pictureBox8.ImageLocation = "unahotels.jpg";
                pictureBox4.ImageLocation = "hotel jolie.jpg";
                pictureBox5.ImageLocation = "sheraton milan.jpg";
                pictureBox6.ImageLocation = "le ali del frassino.jpg";
                pictureBox7.ImageLocation = "hotel grand visconti.jpg";

               
                radioButton1.Text = Otelismi.HotelViennaOstenda.ToString();
                radioButton2.Text = Otelismi.CorteSanMattia.ToString();
                radioButton3.Text = Otelismi.HotelFonteBoiola.ToString();
                radioButton4.Text = Otelismi.UnahotelsCusaniMilano.ToString();
                radioButton5.Text = Otelismi.HotelNewJolie.ToString();
                radioButton6.Text = Otelismi.SheratonMilanMalpensoAirportHotel.ToString();
                radioButton7.Text = Otelismi.OtelLeAliDelFrassino.ToString();
                radioButton8.Text = Otelismi.HotelGrandViscontiPalace.ToString();

              
                foreach (var prd in sepet.GetAtama())
                {
                   
                    otelsehir.otelisim(Otelismi.HotelViennaOstenda);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label7.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.CorteSanMattia);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label13.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HotelFonteBoiola);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label19.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.UnahotelsCusaniMilano);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label25.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HotelNewJolie);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label31.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.SheratonMilanMalpensoAirportHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.OtelLeAliDelFrassino);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label43.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HotelGrandViscontiPalace);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label49.Text = prd.Fiyat.ToString();

                  
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (Atama.isim == "Arjantin")
            {
               
                sepet.birim = atama.y;
                
                label8.Text = otelsehir.y;
                label12.Text = otelsehir.y;
                label18.Text = otelsehir.y;
                label24.Text = otelsehir.y;
                label30.Text = otelsehir.y;
                label37.Text = otelsehir.y;
                label42.Text = otelsehir.y;
                label48.Text = otelsehir.y;

                pictureBox1.ImageLocation = "wyndham nordelta tigre.png";
                pictureBox2.ImageLocation = "ch madero.jpg";
                pictureBox3.ImageLocation = "nh bariloche.jpg";
                pictureBox8.ImageLocation = "howard.jpg";
                pictureBox4.ImageLocation = "algodon.jpg";
                pictureBox5.ImageLocation = "hotel alvear.jpg";
                pictureBox6.ImageLocation = "sheraton mar del plata.jpg";
                pictureBox7.ImageLocation = "hotel del casco.jpg";

                radioButton1.Text = Otelismi.WyndhamNordeltaTigre.ToString();
                radioButton2.Text = Otelismi.CHMaderoUrbanoSuites.ToString();
                radioButton3.Text = Otelismi.HotelNHBarilocheEdelweiss.ToString();
                radioButton4.Text = Otelismi.HotelHowardJohnsonTrenqueLauquen.ToString();
                radioButton5.Text = Otelismi.AlgodanMansionHotel.ToString();
                radioButton6.Text = Otelismi.HotelAlvearPalace.ToString();
                radioButton7.Text = Otelismi.SheratonMarDelPlataHotel.ToString();
                radioButton8.Text = Otelismi.HotelDelCasco.ToString();

             
                foreach (var prd in sepet.GetAtama())
                {
                   
                    otelsehir.otelisim(Otelismi.WyndhamNordeltaTigre);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label7.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.CHMaderoUrbanoSuites);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label13.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HotelNHBarilocheEdelweiss);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label19.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HotelHowardJohnsonTrenqueLauquen);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label25.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.AlgodanMansionHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label31.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HotelAlvearPalace);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.SheratonMarDelPlataHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label43.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.HotelDelCasco);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label49.Text = prd.Fiyat.ToString();

                   
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

            if (Atama.isim == "Japonya")
            {
               
                sepet.birim = atama.k;
                           
                label8.Text = otelsehir.k;
                label12.Text = otelsehir.k;
                label18.Text = otelsehir.k;
                label24.Text = otelsehir.k;
                label30.Text = otelsehir.k;
                label37.Text = otelsehir.k;
                label42.Text = otelsehir.k;
                label48.Text = otelsehir.k;

               
                pictureBox1.ImageLocation = "rihga.jpeg";
                pictureBox2.ImageLocation = "nest hotel.jpg";
                pictureBox3.ImageLocation = "ark hotel.jpg";
                pictureBox8.ImageLocation = "unizo osaka.jpg";
                pictureBox4.ImageLocation = "via Inn asakusa.jpg";
                pictureBox5.ImageLocation = "grandouce.jpg";
                pictureBox6.ImageLocation = "apa villa hotel.jpg";
                pictureBox7.ImageLocation = "mystays shin.jpg";

                radioButton1.Text = Otelismi.RighaNakanoshimaInnOsakaHotel.ToString();
                radioButton2.Text = Otelismi.NestHotelKumamoto.ToString();
                radioButton3.Text = Otelismi.ArkHotelOsakaShinsaibashi.ToString();
                radioButton4.Text = Otelismi.UnizoOsakaUmedaHotel.ToString();
                radioButton5.Text = Otelismi.ViaInnAsakusaHotel.ToString();
                radioButton6.Text = Otelismi.GrandouceHanazonocho.ToString();
                radioButton7.Text = Otelismi.ApaVillaHotelYodoyabashi.ToString();
                radioButton8.Text = Otelismi.MystaysShinOsakaHotel.ToString();

                foreach (var prd in sepet.GetAtama())
                {
                    
                    otelsehir.otelisim(Otelismi.RighaNakanoshimaInnOsakaHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label7.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.NestHotelKumamoto);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label13.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.ArkHotelOsakaShinsaibashi);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label19.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.UnizoOsakaUmedaHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label25.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.ViaInnAsakusaHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label31.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.GrandouceHanazonocho);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label38.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.ApaVillaHotelYodoyabashi);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label43.Text = prd.Fiyat.ToString();

                    otelsehir.otelisim(Otelismi.MystaysShinOsakaHotel);
                    comboBox2.Items.Add(prd.Fiyat.ToString());
                    label49.Text = prd.Fiyat.ToString();

                  
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }


            if (Atama.isim == "Norveç")
            {
               
                sepet.birim = atama.t;
                                 
                label8.Text = otelsehir.t;
                label12.Text = otelsehir.t;
                label18.Text = otelsehir.t;
                label24.Text = otelsehir.t;
                label30.Text = otelsehir.t;
                label37.Text = otelsehir.t;
                label42.Text = otelsehir.t;
                label48.Text = otelsehir.t;

        
                pictureBox1.ImageLocation = "marken.jpg";
                pictureBox2.ImageLocation = "kjobmandsgaarden.jpg";
                pictureBox3.ImageLocation = "stavanger.jpg";
                pictureBox8.ImageLocation = "bergo otel.jpg";
                pictureBox4.ImageLocation = "geilo.jpg";
                pictureBox5.ImageLocation = "ami hotel.jpg";
                pictureBox6.ImageLocation = "comfort hotel.jpg";
                pictureBox7.ImageLocation = "nordic.jpg";

             
                radioButton1.Text = Otelismi.MarkenGuesthouseHotel.ToString();
                radioButton2.Text = Otelismi.KjobmandsgaardenHotel.ToString();
                radioButton3.Text = Otelismi.StavangerLilleHotel.ToString();
                radioButton4.Text = Otelismi.BergoHotel.ToString();
                radioButton5.Text = Otelismi.GeiloVandrerhjem.ToString();
                radioButton6.Text = Otelismi.AmiHotel.ToString();
                radioButton7.Text = Otelismi.ComfortHotelRunway.ToString();
                radioButton8.Text = Otelismi.NordicChoiceHotel.ToString();

              
                foreach (var prd in sepet.GetAtama())
                {
                    
                    otelsehir.otelisim(Otelismi.MarkenGuesthouseHotel);
                    label7.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());

                    otelsehir.otelisim(Otelismi.KjobmandsgaardenHotel);
                    label13.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());

                    otelsehir.otelisim(Otelismi.StavangerLilleHotel);
                    label19.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());

                    otelsehir.otelisim(Otelismi.BergoHotel);
                    label25.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());

                    otelsehir.otelisim(Otelismi.GeiloVandrerhjem);
                    label31.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());

                    otelsehir.otelisim(Otelismi.AmiHotel);
                    label38.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());

                    otelsehir.otelisim(Otelismi.ComfortHotelRunway); ;
                    label43.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());

                    otelsehir.otelisim(Otelismi.NordicChoiceHotel);
                    label49.Text = prd.Fiyat.ToString();
                    comboBox2.Items.Add(prd.Fiyat.ToString());

                 
                    string[] items = comboBox2.Items.OfType<string>().Distinct().ToArray();
                    comboBox2.Items.Clear();
                    for (int i = 0; i < items.Length; i++)
                        comboBox2.Items.Add(items[i]);
                }
            }

           
            label6.Text = otelsehir.günlük;
            label9.Text = otelsehir.internet;
            label10.Text = otelsehir.klima;
            label11.Text = otelsehir.resepsiyon;
          
            pictureBox9.ImageLocation = "wifi.jpg";
            pictureBox10.ImageLocation = "klima.png";
            pictureBox11.ImageLocation = "resepsiyon.png";

            label14.Text = otelsehir.günlük;
            label15.Text = otelsehir.kahvaltı;
            label16.Text = otelsehir.otopark;
            label17.Text = otelsehir.internet;
            pictureBox12.ImageLocation = "yemek.jpg";
            pictureBox13.ImageLocation = "oto.png";
            pictureBox14.ImageLocation = "wifi.jpg";

            label20.Text = otelsehir.günlük;
            label21.Text = otelsehir.kahvaltı;
            label22.Text = otelsehir.valiz;
            label23.Text = otelsehir.klima;
            pictureBox15.ImageLocation = "yemek.jpg";
            pictureBox16.ImageLocation = "valiz.png";
            pictureBox17.ImageLocation = "klima.png";

            label26.Text = otelsehir.günlük;
            label27.Text = otelsehir.internet;
            label28.Text = otelsehir.yemek;
            label29.Text = otelsehir.oto;
            pictureBox19.ImageLocation = "wifi.jpg";
            pictureBox18.ImageLocation = "yemek.jpg";
            pictureBox20.ImageLocation = "oto.png";

            label32.Text = otelsehir.günlük;
            label33.Text = otelsehir.internet;
            label34.Text = otelsehir.spor;
            label35.Text = otelsehir.havuz;
            pictureBox21.ImageLocation = "wifi.jpg";
            pictureBox22.ImageLocation = "spor.png";
            pictureBox23.ImageLocation = "havuz.jpg";

            label39.Text = otelsehir.günlük;
            label36.Text = otelsehir.kapalıhavuz;
            label40.Text = otelsehir.oto;
            label41.Text = otelsehir.kahvaltı;
            pictureBox24.ImageLocation = "havuz.jpg";
            pictureBox25.ImageLocation = "oto.png";
            pictureBox26.ImageLocation = "yemek.jpg";

            label44.Text = otelsehir.günlük;
            label45.Text = otelsehir.yemek;
            label46.Text = otelsehir.spor;
            label47.Text = otelsehir.havuz;
            pictureBox27.ImageLocation = "yemek.jpg";
            pictureBox28.ImageLocation = "spor.png";
            pictureBox29.ImageLocation = "havuz.jpg";

            label50.Text = otelsehir.günlük;
            label51.Text = otelsehir.oto;
            label52.Text = otelsehir.internet;
            label53.Text = otelsehir.kapalıhavuz;
            pictureBox30.ImageLocation = "oto.png";
            pictureBox31.ImageLocation = "wifi.jpg";
            pictureBox32.ImageLocation = "havuz.jpg";


        }

        public int butçe, toplam;
        public int kisi;
        public int w ;
        public double zaman;
        public String süre;
        public String otelismi;

   
        private void button1_Click(object sender, EventArgs e)
        {
        
            butçe = Convert.ToInt32(comboBox2.Text);

          
            kisi = Convert.ToInt32(comboBox1.Text);

       
            TimeSpan fark = dateTimePicker2.Value - dateTimePicker1.Value;
            
            zaman = fark.TotalDays;
           
            w = Convert.ToInt32(zaman);

         
            Sepet.günsayisi = w;
            Sepet.kisisayisi = kisi.ToString();
            admingiris2.kisi = kisi.ToString();
          
            otelsehir.değiştir(butçe, kisi, w);
           
            otelsehir.Hesap();
          
         
            if (comboBox2.Text == "50" || comboBox2.Text == "50000")
            {
                label6.Text = "Toplam";
                label14.Text = "Toplam";
              
                label7.Text = otelsehir.toplam.ToString();
                label13.Text = otelsehir.toplam.ToString();
              
                panel2.Enabled = false;
                panel4.Enabled = false;
                panel3.Enabled = false;
                panel5.Enabled = false;
                panel7.Enabled = false;
                panel9.Enabled = false;
               
                panel8.BackColor = Color.DarkGray;
                panel6.BackColor = Color.DarkGray;
                label7.BackColor = Color.Green;
                label7.ForeColor = Color.White;
                label13.BackColor = Color.Green;
                label13.ForeColor = Color.White;
            }


            if (comboBox2.Text == "100" || comboBox2.Text == "100000")
            {
                label20.Text = "Toplam";
                label26.Text = "Toplam";
                label32.Text = "Toplam";
              
                label19.Text = otelsehir.toplam.ToString();
                label25.Text = otelsehir.toplam.ToString();
                label31.Text = otelsehir.toplam.ToString();
              
                panel3.Enabled = false;
                panel5.Enabled = false;
                panel7.Enabled = false;
                panel6.Enabled = false;
                panel8.Enabled = false;
              
                panel4.BackColor = Color.DarkGray;
                panel2.BackColor = Color.DarkGray;
                panel9.BackColor = Color.DarkGray;
                label19.BackColor = Color.Green;
                label19.ForeColor = Color.White;
                label25.BackColor = Color.Green;
                label25.ForeColor = Color.White;
                label31.BackColor = Color.Green;
                label31.ForeColor = Color.White;

            }


            if (comboBox2.Text == "200" || comboBox2.Text == "200000")
            {
                label39.Text = "Toplam";
                label44.Text = "Toplam";
                label50.Text = "Toplam";
               
                label38.Text = otelsehir.toplam.ToString();
                label43.Text = otelsehir.Fiyat.ToString();
                label49.Text = otelsehir.toplam.ToString();
               
                panel2.Enabled = false;
                panel4.Enabled = false;
                panel6.Enabled = false;
                panel8.Enabled = false;
                panel9.Enabled = false;
               
                panel7.BackColor = Color.DarkGray;
                panel5.BackColor = Color.DarkGray;
                panel3.BackColor = Color.DarkGray;
                label38.BackColor = Color.Green;
                label38.ForeColor = Color.White;
                label43.BackColor = Color.Green;
                label43.ForeColor = Color.White;
                label49.BackColor = Color.Green;
                label49.ForeColor = Color.White;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            panel2.Enabled = true;
            panel4.Enabled = true;
            panel3.Enabled = true;
            panel5.Enabled = true;
            panel7.Enabled = true;
            panel9.Enabled = true;
            panel6.Enabled = true;
            panel8.Enabled = true;
            panel8.BackColor = Color.Silver;
            panel6.BackColor = Color.Silver;
            label7.BackColor = Color.Silver;
            label7.ForeColor = Color.Black;
            label13.BackColor = Color.Silver;
            label13.ForeColor = Color.Black;

            panel4.BackColor = Color.Silver;
            panel2.BackColor = Color.Silver;
            panel9.BackColor = Color.Silver;
            label19.BackColor = Color.Silver;
            label19.ForeColor = Color.Black;
            label25.BackColor = Color.Silver;
            label25.ForeColor = Color.Black;
            label31.BackColor = Color.Silver;
            label31.ForeColor = Color.Black;

            panel7.BackColor = Color.Silver;
            panel5.BackColor = Color.Silver;
            panel3.BackColor = Color.Silver;
            label38.BackColor = Color.Silver;
            label38.ForeColor = Color.Black;
            label43.BackColor = Color.Silver;
            label43.ForeColor = Color.Black;
            label49.BackColor = Color.Silver;
            label49.ForeColor = Color.Black;

            label6.Text = otelsehir.günlük;
            label14.Text = otelsehir.günlük;
            label20.Text = otelsehir.günlük;
            label26.Text = otelsehir.günlük;
            label32.Text = otelsehir.günlük;
            label39.Text = otelsehir.günlük;
            label44.Text = otelsehir.günlük;
            label50.Text = otelsehir.günlük;
            label7.Text = "50";
            label13.Text = "50";
            label19.Text = "100";
            label25.Text = "100";
            label31.Text = "100";
            label38.Text = "200";
            label43.Text = "200";
            label49.Text = "200";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void turToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Tur tur = new Tur();
            this.Hide();
            tur.Show();
        }

        private void restoranToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Restoran reestoran = new Restoran();
            this.Hide();
           reestoran.Show();
        }

        private void katalogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kayıtOlunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitsayfasi kayıtol = new kayitsayfasi();
            this.Hide();
            kayıtol.Show();

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

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

        private void girişYapınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            girisYapin giris = new girisYapin();
            this.Hide();
            giris.Show();
        }

        private void konaklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            if (radioButton1.Checked)
            {
               
                otelsehir.Fiyat = Convert.ToInt32(label7.Text);
               
                otelsehir.gonder(radioButton1.Text);
            }
            if (radioButton2.Checked)
            {
               
                otelsehir.Fiyat = Convert.ToInt32(label13.Text);
              
                otelsehir.gonder(radioButton2.Text);
            }
            if (radioButton3.Checked)
            {
               
                otelsehir.Fiyat = Convert.ToInt32(label19.Text);
               
                otelsehir.gonder(radioButton3.Text);
            }
            if (radioButton4.Checked)
            {
                otelsehir.Fiyat = Convert.ToInt32(label25.Text);
                
                otelsehir.gonder(radioButton4.Text);
            }
            if (radioButton5.Checked)
            {
                otelsehir.Fiyat = Convert.ToInt32(label31.Text);
               
                otelsehir.gonder(radioButton5.Text);
            }
            if (radioButton6.Checked)
            {
               
                otelsehir.Fiyat = Convert.ToInt32(label38.Text);
        
                otelsehir.gonder(radioButton6.Text);
            }
            if (radioButton7.Checked)
            { 
            
                otelsehir.Fiyat = Convert.ToInt32(label43.Text);
             
                otelsehir.gonder(radioButton7.Text);
            }
            if (radioButton8.Checked)
            { 
               
                otelsehir.Fiyat = Convert.ToInt32(label49.Text);
                
                otelsehir.gonder(radioButton8.Text);
            }
  
            Sepet.isim = otelsehir.otel;
            Sepet.günlükfiyati = otelsehir.günlükfiyati.ToString();
            otelsehir.Hesap();
            Sepet.oteltoplam = otelsehir.toplam.ToString();
           
            otelsehir.Fiyat = otelsehir.toplam;
            admingiris2.oteltoplami = otelsehir.toplam.ToString();
            
            Sepet.total = sepet.TotalPrice();
            MessageBox.Show("Seçiminiz Sepete Eklenmiştir");

        
    }
    }
}
