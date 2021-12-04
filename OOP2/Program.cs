using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Cem Doruk";
            musteri1.Soyadi = "Gürsoy";
            musteri1.TcNo = "123456789";





            //Tüzel Müşteri 
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //Musteri hem Gerçek hem de Tüzel müşteriler classlarını tutabiliyor.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            //** Musteri manager'a Ekle methodu içinde Musteri musteri parametresi yolladıgımız icin;
            //** ve Musteri classını da diğer tüm classlara inheritance yaptırdıgımız ve Musteri class'ı hepsinin referanslarını tuttugu için
            //Sonuc olarak Musterimanager'a Gercek müsteri, Tüzel Müsteriyi de rahatlıkla yollayabiliriz.






        }
    }
}
