using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string UrunAdi = "elma";
            //double fiyat = 10;
            //string aciklama = "elma gibi elma";

            //string[] meyveler = new string[] {"Elma","Karpuz" };


            //Urun classından tanımladıgımız propları Main class'ta cagırdık ve onlara değerler verdik.

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[]
            {
                urun1,urun2
            };

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("----------------Metodlar--------------");

            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //asagıdaki kullanım yanlıs kullanımdır

            sepetManager.Ekle2("Armut", "Yeşil", 15, 10);
            sepetManager.Ekle2("Elma", "Yeşil", 3, 9);
            sepetManager.Ekle2("Karpuz", "Tonton Karpuz", 13, 25);
            Console.ReadLine();


            //    Console.WriteLine("------------burası tamamen deneme--------------"); // VE OLDU!
            //    urundeneme urundeneme1 = new urundeneme();

            //    urundeneme1.id = 1;
            //    urundeneme1.urunadi = "domates";
            //    urundeneme1.aciklama = "12345";

            //    urundeneme urundeneme2 = new urundeneme();
            //    urundeneme2.id = 2;
            //    urundeneme2.urunadi = "patates";
            //    urundeneme2.aciklama = "kızartma";


            //    urundeneme[] uruncuk = new urundeneme[]
            //    {
            //        urundeneme1,urundeneme2
            //    };

            //    foreach (urundeneme urundeneme in uruncuk)
            //    {
            //        Console.WriteLine(urundeneme.id);
            //        Console.WriteLine(urundeneme.urunadi);
            //        Console.WriteLine(urundeneme.aciklama);
            //    }



            //    sepetdeneme deneme = new sepetdeneme();
            //    deneme.Sepetekle(urundeneme1);
            //    deneme.Sepetekle(urundeneme2);



            //}
        }

    }
}


//do not repeat yourself.