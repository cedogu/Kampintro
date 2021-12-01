using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            MyList<string> isimler = new MyList<string>();
            isimler.Add("Doruk");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);


            //triallllllllllllll
            //List<string> liste = new List<string>();
            //liste.Add("doruk");
            //Console.WriteLine(liste.Count);

            Console.WriteLine("Hello World!");



            //MyList classında Add isminde method tanımlıyoruz, onun türünü T item yapıyoruz
            //T = type'dan gelir ve herhangi bir type'i kabul edeceğini programa söylüyoruz.
            //Program.cs'ye geldigimizde Mylist<string>, Mylist<boolean>, MyList<int> vb. herhangi bir tipte listemizi/generik olusturabiliriz.
        }
    }
}
