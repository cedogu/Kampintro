using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //int, float, decimal,double, bool ---- değer tipli (value type)
            //array, interface,class --- referanst tip (reference type)
            //bellekte stack ve heap diye iki bölge var
            //değer tipliler stack kısmına giderken referans tipliler heap bölgesine gidiyor.
            //new dediğimiz zaman otomatik olarak heap bölgesine atıyoruz ve orada işleme alınıyor. new= bellekte adres olustur
            //değer tiplerde değeri atıyoruz, referans tiplerde adresi atıyoruz.



        }
    }
}
