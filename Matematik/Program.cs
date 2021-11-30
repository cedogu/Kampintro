using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);

            dortIslem.Topla(10, 20);

            Console.WriteLine();

            DortIslem dortIslem1 = new DortIslem();
            dortIslem.Carpma(2, 5);
            dortIslem.Carpma(4, 7);




            Console.Read();

        }
    }
}
