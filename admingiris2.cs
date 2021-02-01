using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
using System.Text; 

namespace _4.Sayfa
{
    public partial class admingiris2 : Form
    {
        public admingiris2()
        {
            InitializeComponent();
        }

        public static string oteltoplami;
        public static string kisi;
        public static string muzetoplami;
        public static string muzekisi;
        public static string restorantoplami;
        public static string restorankisi;
        public static string turtoplami;
        public static string turkisi;
        public static string ulasımtoplami;
        public static string ulasımkisi;
        adminSehir gir = new adminSehir();
       

        private void admingiris2_Load(object sender, EventArgs e)
        {
           
           
            this.AutoScroll = true;
            this.MaximizeBox = false;
            BackColor = Color.Silver;
            menuStrip1.BackColor = Color.Silver;

            
            pictureBox1.ImageLocation = "logo1.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            
            label1.Text = gir.lx1;
            label2.Text = gir.lx2;

            
            File.AppendAllText("admin.txt",adminSehir.kisi+": "+Environment.NewLine);
            File.AppendAllText("admin.txt","Restoran: " + Sepet.restoranisim + " restoranı " + restorankisi + " kişi için " + restorantoplami + " ücret ödedi."+Environment.NewLine);
            File.AppendAllText("admin.txt", "Müze: " + ", " + Sepet.müzeisim + " müzesi " + muzekisi + " kişi için " + muzetoplami + " ücret ödedi."+Environment.NewLine);
            File.AppendAllText("admin.txt", "Otel: "+ Sepet.isim + " oteli " + kisi + " kişi için " + oteltoplami + " ödedi."+Environment.NewLine);
            File.AppendAllText("admin.txt", "Tur: " + Sepet.turisim + " turu " + turkisi + " kişi için " + turtoplami + " ödedi."+Environment.NewLine);
            File.AppendAllText("admin.txt", "Ulasım:" + Sepet.ulasimisim + " turizm " + ulasımkisi + " kişi için " + ulasımtoplami + " ödedi."+Environment.NewLine);
            File.AppendAllText("admin.txt", "-----------------------"+Environment.NewLine);

            
            string oku = File.ReadAllText("admin.txt");
            
            richTextBox1.Text = oku;
           
        }

        private void AnasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminSehir.kisi = "0";
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
            admingiris2.oteltoplami = "0";
            admingiris2.kisi = "0";
            admingiris2.restorankisi = "0";
            admingiris2.restorantoplami = "0";
            admingiris2.muzetoplami = "0";
            admingiris2.muzekisi = "0";
            admingiris2.turtoplami = "0";
            admingiris2.turkisi = "0";
            admingiris2.ulasımkisi = "0";
            admingiris2.ulasımtoplami = "0";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
