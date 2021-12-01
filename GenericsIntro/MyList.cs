using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items = new T[] { };

        //constructor, aslında bir methodtur.class new denildikce otomatik calısır.
        //Constructor class ile aynı isimlere sahiptir.
        //Temp yapmamızın sebebi; New yaptıgımız zaman ref tipliye döndügü icin bir önceki silinir, bir önceki değerlerin silinmemesi icin de biz ona TempArray veririz
        //böylelikle de değerler kaybolmadan length'i +1 arttırabiliriz.
        //geçici olarak TempArray'da tuttugumuz değerleri de items'a eklemek için for içine bir döngü yaparız ve onları eşleştiririz, Aşağıda yaptıgımız gibi. items[i]=tempArray[i] 
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T [] Items
        {
            get { return items;}
        }
    }
}
