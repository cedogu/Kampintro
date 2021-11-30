using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";
            //array - dizi 

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", "programlaya başlangıç için temel kurs", "Java", "Python", "C++"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("for bitti");



            //foreach dizilere de uygulanır.
            //foreach dizilerde daha kolay cözümleme için kullanılır

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine();
            Console.WriteLine("sayfa sonu - footer");
            Console.ReadLine();
        }
    }
}
