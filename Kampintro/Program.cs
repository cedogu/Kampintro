using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //typesafety= tip güvenliği 
            //do not repeat yourself!
            //kategoriEtiketi = değer tutucu

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true; //true da verebiliriz. 1 ya da 0 ile gider.
            double dolarDun = 7.55;
            double dolarBugun = 7.55;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonunu Göster");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }

            //if (sistemeGirisYapmisMi == false)
            //{
            //    Console.WriteLine("sisteme giriş yaptınız");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen tekrar deneyiniz");
            //}


            Console.Read();
        }
    }
}
