using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sayfa
{   
    public class restoranSehir : Atama, IYemekSatis
    {
        public string Yadi, Yk, Yö, Ya, Yt, Yap, Yisim, Yi;
        internal static int sonuc;
        public int YFiyati, YAdeti, YSonuc, Yİf;
        public int YemekFiyat
        {
            get { return YFiyati; }
            set { YFiyati = value; }
        }
        public int YemekAdet
        {
            get { return YAdeti; }
            set { YAdeti = value; }
        }
        public int YSonucu
        {
            get { return Yİf; }
            set { Yİf = value; }
        }
        public string Yad {
            get { return Yadi; }
            set { Yadi = value; }
        }
        public string Ybolge {
            get { return Yadi; }
            set { Yadi = value; }
        }
        public string Ykhv
        {
            get { return Yk; }
            set { Yk = value; }
        }
        public string Yögley {
            get { return Yö; }
            set { Yö = value; }
        }
        public string Yaksmy
        {
            get { return Ya; }
            set { Ya = value; }
        }
        public string Yaprtf {
            get { return Yap; }
            set { Yap = value; }
        }
        public string Ytatlı
        {
            get { return Yt; }
            set { Yt = value; }
        }

        
        public int KisiAdet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int YeniSayi { get; set; }

       
        public override int Hesap()
        {
            
            sonuc = YAdeti * YFiyati;
            return sonuc;
        }
        

    }
   public class Şehiregörerestoran : Atama
    {
        public static string a = Atama.isim;
public override int Hesap()
        {
            throw new NotImplementedException();
        }
    }

}

        
    
    
    

