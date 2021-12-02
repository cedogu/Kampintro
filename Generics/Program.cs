using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("Dublin");
            sehirler.Add("Dublin");
            sehirler.Add("Dublin");
            sehirler.Add("Dublin");
            sehirler.Add("Dublin");
            sehirler.Add("Dublin");
            Console.WriteLine(sehirler.Count);




            //public void Add methoduna bir ekleme yapmadıgımız sürece bu halde calıstırınca 1 - 0 alırız. 
            MyList<string> sehirler2 = new MyList<string>();

            sehirler2.Add("Dublin");  /// sehirler2 kısmı MyList'e hangi tipi verirsek o olur,
            sehirler2.Add("Dublin");  /// sehirler2 kısmı MyList'e hangi tipi verirsek o olur,
            sehirler2.Add("Dublin");  /// sehirler2 kısmı MyList'e hangi tipi verirsek o olur,
            sehirler2.Add("Dublin");  /// sehirler2 kısmı MyList'e hangi tipi verirsek o olur,
            sehirler2.Add("Dublin");  /// sehirler2 kısmı MyList'e hangi tipi verirsek o olur,
            sehirler2.Add("Dublin");  /// sehirler2 kısmı MyList'e hangi tipi verirsek o olur,
            sehirler2.Add("Dublin");  /// sehirler2 kısmı MyList'e hangi tipi verirsek o olur,
            Console.WriteLine(sehirler2.Count);

        }
    }

    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;  //önceki verilen T değerlerinin kaybolmaması icin geçiçi bir dizi olustururuz ve o değerleri orada tutarız.
                         //for ile birbirine bağlayarak gelen eski ve yeni değerleri bir arada tutarız. asagıda örneği var.


        public MyList()   //MyList'e New dediğimizde bu blok calısır.
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            //buradaki T hangi tipi verirsek verelim MyList generic list'te onu çalıstırır. T = Type
            _tempArray = _array;  //temparray = _array'ın referansını tutuyor.
            _array = new T[_array.Length + 1]; // arraylarda eleman sayısını arttırınca new yapmamız lazım. _array T'ye esit oldugu icin T'ye atılan her değer _array'in de genisligini +1 yapar.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item; //böyle yapınca sonuc 1-1 oluyor ya da biz ne kadar eklersek.
        }



        public int Count   //mylist'in count'u cagırırsak array'in lenghtini verir.
        {
            get { return _array.Length; }

        }

    }

   

}
