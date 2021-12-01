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

            Console.WriteLine(isimler.Length);

            isimler.Add("Cem");
            Console.WriteLine(isimler.Length);




            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }


            Console.WriteLine("----------");


            //Homework
            Console.WriteLine("----Homework----");
            List<string> people = new List<string>();
            people.Add("Madolyn");
            people.Add("Chris");
            people.Add("John");
            people.Add("Shyla");
            Console.WriteLine("number of this array is :" + people.Count);
            foreach (var name in people)
            {
                Console.WriteLine("My people in this array : " + name);
            }

            Console.WriteLine("------------------------");

            List<string> people2 = new List<string>
            {
                "Solomon", "David", "Jan","Ivana","Eva"
            };

            Console.WriteLine("number of people in this array is: " + people2.Count);

            foreach (var name2 in people2)
            {
                Console.WriteLine("my people in this array: "+ name2);
            }
            Console.ReadLine();

            








            //first trial
            //List<string> liste = new List<string>();
            //Console.WriteLine(liste.Count);


            // second triallllllllllllll
            //List<string> liste = new List<string>();
            //liste.Add("doruk"); but worked!!!
            //Console.WriteLine(liste.Count);




            //MyList classında Add isminde method tanımlıyoruz, onun türünü T item yapıyoruz
            //T = type'dan gelir ve herhangi bir type'i kabul edeceğini programa söylüyoruz.
            //Program.cs'ye geldigimizde Mylist<string>, Mylist<boolean>, MyList<int> vb. herhangi bir tipte listemizi/generik olusturabiliriz.
        }
    }
}
