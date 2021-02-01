using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{
   
    public enum MuzeIsmi
    {
        GöremeAçıkHavaMüzesi ,
        KaymaklıYeraltıŞehri ,
        StJeanKilisesi ,
        AçıksarayÖrenyeri ,
        NevsehirMuzesi ,
        ZelveAçıkHavaMüzesi ,

        TopkapıSarayı ,
        İstanbulArkeolojiMüzesi ,
        DenizMüzesi ,
        YerebatanSarnıcı ,
        OyuncakMüzesi ,
        KlasikOtmobilMüzesi ,

        AntalyaMuzesi ,
        SunaİnanKaleiçiMüzesi ,
        DenizBiyolojisiMüzesi ,
        Sandland ,
        HababamSınıfıMüzesi ,
        EtnografyaMüzesi ,

        MardinMüzesi ,
        SakıpSabancıKentMüzesi ,
        EğitimTarihiMüzesiArtuklu ,
        MidyatKonukevi ,
        MorBehnamKırklıKilisesi  ,
        DaraAntikKenti ,

        SümelaManastırı ,
        TrabzonMüzesi ,
        AtatürkKöşkü ,
        OrtahisarTarihMüzesi ,
        EdebiyatMüzesi ,
        TrabzonSporMüzesi ,

        AtatürkveKurtuluşSavaşıMüzesiAnıtkabir ,
        CumhuriyetMüzesi ,
        KurtuluşSavaşıMüzesi ,
        AnadoluMedeniyetleriMüzesi ,
        EtnografyaMuzesiAnkara ,
        ODTÜBilimveTeknolojiMüzesi ,

        BergamaMuseum ,
        AlteNationalGalerie ,
        BodeMuseum ,
        AltePinakothek ,
        StädelMuseum ,
        SenckenbergMuseum ,

        GalleriaBorghese ,
        Uffizi ,
        PittiPalace ,
        CaptaliniMuseum ,
        Pantheon ,
        GalileoMuseum ,

        MuseoNacionaldeArteDecorativo ,
        BenitoQuinquelaMartínMuseum ,
        MuseoDeLaPlata ,
        XulSolarMuseum ,
        AmaliaLacrozdeFortabatArtCollection ,
        MuseodeArteContemporáneodeSalta ,

        TokyoNationalMuseum ,
        TeamLabPlanets ,
        OharaMuseumofArt ,
        MihoMuseum ,
        PolaMuseumofArt ,
        TokyoNationalMuseumHeiseikan ,

        TheFramMuseum ,
        NorwegianMaritimeMuseum ,
        NobelPeaceCenter ,
        OscarshallPalace ,
        KistefosMuseum ,
        TheNorwegianMuseumofCulturalHistory ,

    }

    
    public class MuzeSehir : Atama
    {
       

        public String txt1 = "Kişi Sayısı: ";
        public String txt2 = "Tarih:";
        public String txt3 = "Bütçe:";
        public String txt4 = "Sirala";
        public String txt5 = "Temizle";
        public String txt6 = "Sepete Ekle";
        public String txt7 = "Ödeme";

        public String gun = "Her gün Açık.";
        public String gun1 = "Hafta İçi Açık.";


        public String text1 = "Giriş Ücreti: ";
        public String text2 = "Nasıl Gidilir: ";

       
        public string muzeismi;
        public int fiyat;
        public  int toplam=0;
        public int kisi;
      


        public MuzeSehir()
        {

        }
        
       
        public void Kayıt(MuzeIsmi isim)
        {
           
            switch (isim)
            {
                
                case MuzeIsmi.Pantheon:
                case MuzeIsmi.ODTÜBilimveTeknolojiMüzesi:
                case MuzeIsmi.EdebiyatMüzesi:
                case MuzeIsmi.EtnografyaMüzesi:
                case MuzeIsmi.HababamSınıfıMüzesi:
                case MuzeIsmi.AçıksarayÖrenyeri:
                case MuzeIsmi.NevsehirMuzesi:
                case MuzeIsmi.DaraAntikKenti:
                case MuzeIsmi.EğitimTarihiMüzesiArtuklu:
                    this.Fiyat = 0 ;
                    break;

                case MuzeIsmi.AltePinakothek:
                    this.Fiyat = 5;
                    break;

                case MuzeIsmi.SenckenbergMuseum:
                case MuzeIsmi.MardinMüzesi:
                case MuzeIsmi.SunaİnanKaleiçiMüzesi:
                case MuzeIsmi.ZelveAçıkHavaMüzesi:
                case MuzeIsmi.AtatürkveKurtuluşSavaşıMüzesiAnıtkabir:
                case MuzeIsmi.OrtahisarTarihMüzesi:
                case MuzeIsmi.TrabzonMüzesi:
                case MuzeIsmi.SakıpSabancıKentMüzesi:
                case MuzeIsmi.MidyatKonukevi:
                case MuzeIsmi.DenizBiyolojisiMüzesi:
                case MuzeIsmi.StJeanKilisesi:
                    this.Fiyat = 7;
                    break;

                case MuzeIsmi.CaptaliniMuseum:
                case MuzeIsmi.GalileoMuseum:
                case MuzeIsmi.GalleriaBorghese:
                case MuzeIsmi.AtatürkKöşkü:
                case MuzeIsmi.KlasikOtmobilMüzesi:
                case MuzeIsmi.DenizMüzesi:
                    this.Fiyat = 10;
                    break;

                case MuzeIsmi.PittiPalace:
                case MuzeIsmi.StädelMuseum:
                case MuzeIsmi.BodeMuseum:
                case MuzeIsmi.AlteNationalGalerie:
                case MuzeIsmi.CumhuriyetMüzesi:
                case MuzeIsmi.EtnografyaMuzesiAnkara:
                case MuzeIsmi.KurtuluşSavaşıMüzesi:
                case MuzeIsmi.OyuncakMüzesi:
                case MuzeIsmi.YerebatanSarnıcı:
                    this.Fiyat = 15;
                    break;

                case MuzeIsmi.Uffizi:
                case MuzeIsmi.BergamaMuseum:
                    this.Fiyat = 20;
                    break;

                case MuzeIsmi.MuseoDeLaPlata:
                case MuzeIsmi.AnadoluMedeniyetleriMüzesi:
                case MuzeIsmi.Sandland:
                case MuzeIsmi.AntalyaMuzesi:
                case MuzeIsmi.TrabzonSporMüzesi:
                    this.Fiyat = 45;
                    break;

                case MuzeIsmi.MuseoNacionaldeArteDecorativo:
                case MuzeIsmi.GöremeAçıkHavaMüzesi:
                case MuzeIsmi.SümelaManastırı:
                case MuzeIsmi.İstanbulArkeolojiMüzesi:
                case MuzeIsmi.KaymaklıYeraltıŞehri:
                    this.Fiyat = 50;
                    break;

                case MuzeIsmi.OscarshallPalace:
                case MuzeIsmi.AmaliaLacrozdeFortabatArtCollection:
                case MuzeIsmi.BenitoQuinquelaMartínMuseum:
                case MuzeIsmi.TopkapıSarayı:
                    this.Fiyat = 100;
                    break;

                case MuzeIsmi.NobelPeaceCenter:
                case MuzeIsmi.TheFramMuseum:
                    this.Fiyat = 120;
                    break;

                case MuzeIsmi.KistefosMuseum:
                case MuzeIsmi.TheNorwegianMuseumofCulturalHistory:
                case MuzeIsmi.NorwegianMaritimeMuseum:
                    this.Fiyat = 150;
                    break;
                case MuzeIsmi.XulSolarMuseum:
                    this.Fiyat = 200;
                    break;

                case MuzeIsmi.TokyoNationalMuseum:
                    this.Fiyat = 1000;
                    break;

                case MuzeIsmi.TeamLabPlanets:
                    this.Fiyat = 3200;
                    break;

                case MuzeIsmi.MihoMuseum:
                case MuzeIsmi.OharaMuseumofArt:
                    this.Fiyat = 1300;
                    break;

                case MuzeIsmi.TokyoNationalMuseumHeiseikan:
                    this.Fiyat = 2300;
                    break;

                case MuzeIsmi.PolaMuseumofArt:
                    this.Fiyat = 1800;
                    break;
                default:
                    break;
            }
        }

    
        public void gonder(string muze, int fiyat, int kisi)
        {
            this.muzeismi = muze;
            this.fiyat = fiyat;
            this.kisi = kisi;
        }

      
        public override int Hesap()
        {
            toplam = fiyat * kisi;
            return toplam;
        }

       public int[] fyt = new int[17] { 0, 5, 7, 10, 15, 20, 45, 50, 100, 120, 150, 200, 1000, 1300, 1800, 2300, 3200 };
    }
}
