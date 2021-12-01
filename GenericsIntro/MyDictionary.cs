using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyDictionary<T>
    {
        T[] people;
        T[] tempPeople;


        public MyDictionary()
        {
            people = new T[0];
        }

        public void Add(T person)
        {
            tempPeople = people;
            people = new T[people.Length];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = tempPeople[i];
            }
            people[people.Length - 1] = person;

        }

        public int Count
        {
            get { return people.Length; }
        }
    }


}
