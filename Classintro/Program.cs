using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string adi = "Doruk";
            //int yas = 26;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 95;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Cem Doruk Gürsoy";
            kurs2.IzlenmeOrani = 85;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.KursEgitmeni = "Mehmet Yüksel";
            kurs3.IzlenmeOrani = 91;


            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "PHP";
            kurs4.KursEgitmeni = "Mehmet Önal";
            kurs4.IzlenmeOrani = 90;

            Kurs kurs5 = new Kurs();
            kurs5.KursAdi = "JavaScript and its Frameworks";
            kurs5.KursEgitmeni = "Cem Doruk Gürsoy";
            kurs5.IzlenmeOrani = 99;



            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursEgitmeni + " " + kurs1.IzlenmeOrani);


            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3,kurs4,kurs5
            };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.KursEgitmeni + ": " + kurs.IzlenmeOrani);

            }


            Console.Read();

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
