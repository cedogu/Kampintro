using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Doruk","Cem","Mehmet","Gökhan","Serhat","Mehmet2"};

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[5]);

            //Console.WriteLine("-----------------------------");

            //isimler = new string[6];
            //isimler[4] = "Süleyman";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Doruk", "Cem", "Mehmet", "Gökhan",  };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Serhat");
            Console.WriteLine(isimler2[4]);
          

        }
    }
}
