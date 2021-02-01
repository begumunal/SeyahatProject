using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{
    public class Sepet
    {
      
        private List<Atama> yeni = new List<Atama>();

      
        public void Add(Atama hesap)
        {
            if (hesap != null)
            {
                yeni.Add(hesap);
            }
        }

       
        public List<Atama> GetAtama()
        {
            return yeni;
        }

        public  Sepet() {

        }

        
        public static String isim, müzeisim, turisim, restoranisim, ulasimisim;
        public String sonuç, click1, click2, click3, click4, click5;

        public static String kisisayisi = "0";
        public static String kisisayisimüze = "0";
        public static String kisisayisitur = "0";
        public static String kisisayisirestoran = "0";
        public static String kisisayisiulaşım = "0";


        public static String günlükfiyatmüze = "0";
        public static String günlükfiyattur = "0";
        public static String günlükfiyatrestoran = "0";
        public static String günlükfiyati = "0";
        public static String fiyatulaşım= "0";


        public static String müzetoplam = "0";
        public static String turtoplam = "0";
        public static String restorantoplam = "0";
        public static String oteltoplam = "0";
        public static String ulaşımtoplam = "0";


        public static int günsayisi = 0;
        public static int günsayisitur = 0;
        public String birim;
        public static double total;


       
        public static double totalPrice = 0;

        public double TotalPrice()
        {

            foreach (var toplam in yeni)
            {
                 totalPrice += toplam.Fiyat;
            }
            return totalPrice;
        }

    }
}

