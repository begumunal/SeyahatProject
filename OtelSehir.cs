using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Sayfa
{
 
    public enum Otelismi
    {
        LavantaOtel ,
        RoyalInciAirportHotel ,
        BeyazKöşkOtel ,
        TempoOtel ,
        DivanIstanbulOtel ,
        DoubletreeByHiltonIstanbulOtel ,
        SwissotelTheBosphorus ,
        PeraPalaceHotel ,

        ArsenOtel ,
        UzungölHolidayOtel ,
        GrandVavesOtel ,
        AseliaHotel ,
        ZitasOtelZiganaYaylaTatilKöyü ,
        ParkDedemanOtel ,
        RadissonBluHotel ,
        RoyalComfortHotel ,

        NissLaraHotel ,
        SherwoodPrizeHotel ,
        AkraVHotel ,
        TheCornerParkHotel ,
        MeldaPalaceHotel ,
        RixosDowntownAntalya ,
        LimakLaraDeluxeHotel ,
        TheMarmaraAntalya ,

        HotelİçKale,
        TheGreenParkOtel ,
        BestWesternHotel ,
        AtaköşkHotel ,
        WarwickOtel ,
        AnkaraHiltonOtel ,
        CPAnkaraHotel ,
        NewParkHotel ,

        GöremeRevaHotel ,
        HasCaveKonakÜrgüp  ,
        ElifStoneHouse ,
        SofaHotel ,
        DedeliDeluxeHotel ,
        TheVillageCaveHotel ,
        TaşkonaklarOtel ,
        DereSuites ,

        TuğhanOtel,
        DaraKonağı ,
        MardinOsmanlıKonağı ,
        MaristanTarihiKonak ,
        MaridinOtel ,
        HiltonGardenInnMardin ,
        RamadaPlazaByWyndhamMardin ,
        MardiusTarihiKonakOtel ,

        İntercityHotel ,
        CentroHotelStadtGütersloh ,
        LeonardoHotelHannover ,
        MaritimHotelUlm ,
        HotelLoccumerHof ,
        HiltonDresden ,
        ExcelsiorHotel ,
        SteigenbergerHotel ,

        HotelViennaOstenda ,
        CorteSanMattia ,
        HotelFonteBoiola ,
        UnahotelsCusaniMilano ,
        HotelNewJolie ,
        SheratonMilanMalpensoAirportHotel ,
        OtelLeAliDelFrassino ,
        HotelGrandViscontiPalace ,

        WyndhamNordeltaTigre ,
        CHMaderoUrbanoSuites ,
        HotelNHBarilocheEdelweiss ,
        HotelHowardJohnsonTrenqueLauquen ,
        AlgodanMansionHotel ,
        HotelAlvearPalace ,
        SheratonMarDelPlataHotel ,
        HotelDelCasco ,

        RighaNakanoshimaInnOsakaHotel ,
        NestHotelKumamoto ,
        ArkHotelOsakaShinsaibashi ,
        UnizoOsakaUmedaHotel ,
        ViaInnAsakusaHotel ,
        GrandouceHanazonocho ,
        ApaVillaHotelYodoyabashi ,
        MystaysShinOsakaHotel,

        MarkenGuesthouseHotel ,
        KjobmandsgaardenHotel ,
        StavangerLilleHotel ,
        BergoHotel ,
        GeiloVandrerhjem ,
        AmiHotel ,
        ComfortHotelRunway ,
        NordicChoiceHotel ,
    }

  
    public class OtelSehir:Atama
    {
        public String sehir = Atama.isim;
        public String günlük;
        public String internet;
        public String kapalıhavuz;
        public String havuz;
        public String klima;
        public String resepsiyon;
        public String kahvaltı;
        public String otopark;
        public String oto;
        public String valiz;
        public String yemek;
        public String spor;
        public String otel;

       
        public int günlükfiyati;
        public int kisisayisi;
        public int ücret;
        public int süre;
        public int sayi;
        public void otelisim(Otelismi isim)
        {

  
            switch (isim)
            {
                case Otelismi.LavantaOtel:
                case Otelismi.RoyalInciAirportHotel:
                case Otelismi.ArsenOtel:
                case Otelismi.UzungölHolidayOtel:
                case Otelismi.NissLaraHotel:
                case Otelismi.SherwoodPrizeHotel:
                case Otelismi.HotelİçKale:
                case Otelismi.TheGreenParkOtel:
                case Otelismi.GöremeRevaHotel:
                case Otelismi.HasCaveKonakÜrgüp:
                case Otelismi.TuğhanOtel:
                case Otelismi.DaraKonağı:
                case Otelismi.İntercityHotel:
                case Otelismi.CentroHotelStadtGütersloh:
                case Otelismi.HotelViennaOstenda:
                case Otelismi.CorteSanMattia:
                case Otelismi.WyndhamNordeltaTigre:
                case Otelismi.CHMaderoUrbanoSuites:
                case Otelismi.MarkenGuesthouseHotel:
                case Otelismi.KjobmandsgaardenHotel:
                    this.Fiyat = 50;
                    break;

                case Otelismi.BeyazKöşkOtel:
                case Otelismi.TempoOtel:
                case Otelismi.DivanIstanbulOtel:
                case Otelismi.GrandVavesOtel:
                case Otelismi.AseliaHotel:
                case Otelismi.ZitasOtelZiganaYaylaTatilKöyü:
                case Otelismi.AkraVHotel:
                case Otelismi.TheCornerParkHotel:
                case Otelismi.MeldaPalaceHotel:
                case Otelismi.BestWesternHotel:
                case Otelismi.AtaköşkHotel:
                case Otelismi.WarwickOtel:
                case Otelismi.ElifStoneHouse:
                case Otelismi.SofaHotel:
                case Otelismi.DedeliDeluxeHotel:
                case Otelismi.MardinOsmanlıKonağı:
                case Otelismi.MaristanTarihiKonak:
                case Otelismi.MaridinOtel:
                case Otelismi.LeonardoHotelHannover:
                case Otelismi.MaritimHotelUlm:
                case Otelismi.HotelLoccumerHof:
                case Otelismi.HotelFonteBoiola:
                case Otelismi.UnahotelsCusaniMilano:
                case Otelismi.HotelNewJolie:
                case Otelismi.HotelNHBarilocheEdelweiss:
                case Otelismi.HotelHowardJohnsonTrenqueLauquen:
                case Otelismi.AlgodanMansionHotel:
                case Otelismi.StavangerLilleHotel:
                case Otelismi.BergoHotel:
                case Otelismi.GeiloVandrerhjem:
                    this.Fiyat = 100;
                    break;

                case Otelismi.DoubletreeByHiltonIstanbulOtel:
                case Otelismi.SwissotelTheBosphorus:
                case Otelismi.PeraPalaceHotel:
                case Otelismi.ParkDedemanOtel:
                case Otelismi.RadissonBluHotel:
                case Otelismi.RoyalComfortHotel:
                case Otelismi.RixosDowntownAntalya:
                case Otelismi.LimakLaraDeluxeHotel:
                case Otelismi.TheMarmaraAntalya:
                case Otelismi.AnkaraHiltonOtel:
                case Otelismi.CPAnkaraHotel:
                case Otelismi.NewParkHotel:
                case Otelismi.TheVillageCaveHotel:
                case Otelismi.TaşkonaklarOtel:
                case Otelismi.DereSuites:
                case Otelismi.HiltonGardenInnMardin:
                case Otelismi.RamadaPlazaByWyndhamMardin:
                case Otelismi.MardiusTarihiKonakOtel:
                case Otelismi.HiltonDresden:
                case Otelismi.ExcelsiorHotel:
                case Otelismi.SteigenbergerHotel:
                case Otelismi.SheratonMilanMalpensoAirportHotel:
                case Otelismi.OtelLeAliDelFrassino:
                case Otelismi.HotelGrandViscontiPalace:
                case Otelismi.HotelAlvearPalace:
                case Otelismi.SheratonMarDelPlataHotel:
                case Otelismi.HotelDelCasco:
                case Otelismi.AmiHotel:
                case Otelismi.ComfortHotelRunway:
                case Otelismi.NordicChoiceHotel:
                    this.Fiyat = 200;
                    break;

                case Otelismi.RighaNakanoshimaInnOsakaHotel:
                case Otelismi.NestHotelKumamoto:
                    this.Fiyat = 50000;
                    break;
                case Otelismi.ArkHotelOsakaShinsaibashi:
                case Otelismi.UnizoOsakaUmedaHotel:
                case Otelismi.ViaInnAsakusaHotel:
                    this.Fiyat = 100000;
                    break;
                case Otelismi.GrandouceHanazonocho:
                case Otelismi.ApaVillaHotelYodoyabashi:
                case Otelismi.MystaysShinOsakaHotel:
                    this.Fiyat = 200000;
                    break;


            }

        }

     
        public OtelSehir()
        {

            günlük = "Günlük:";
            internet = "Ücretsiz Wifi";
            kapalıhavuz = "Kapalı yüzme havuzu";
            havuz = "Havuz";
            klima = "Klima";
            resepsiyon = "24 saat açık resepsiyon";
            kahvaltı = "Ücretsiz kahvaltı";
            otopark = "Ücretli otopark";
            oto = "Ücretsiz otopark";
            valiz = "Valiz dolabı";
            yemek = "Ücretsiz akşam yemeği";
            spor = "Spor salonu";
        }

      
        public void gonder(string a)
        {
            this.otel = a;
        }
    
        public void değiştir(int b, int c,int d)
        {
            this.günlükfiyati = b;
            this.kisisayisi = c;
            this.süre = d;
        }

      
        public int toplam = 0;
      
        public override int Hesap()
        {
            if (süre == 0)
            {
                toplam = günlükfiyati * kisisayisi;
            }
            else
            {
                toplam = günlükfiyati * kisisayisi * süre;
            }
            return toplam;

        }
    }
}
