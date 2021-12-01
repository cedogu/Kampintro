using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //int decimal float enum boolean vb. gibi sayısal değerler = değer tiplidir (value types)

            //değer tiplerde atama yaptıktan sonra baska bir atama yapılırsa sonuc degismez
            //yani sayi1=sayi2 yaptık ama 20 değerini okur. sayı 2'yi tekrar degistirip 100 yaparsak sonuc ilk seferki gibi olur. O anki değeri alır
            //sayi2'nin yeni değeri stack'te farklı olarak değerlendirilir.


            //// 1st example
            //int sayi1 = 10;
            //int sayi2 = 20;


            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("sayi 1: " + sayi1);

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("sayilar1'in 0. elemanı " + sayilar1[0]);
            //Console.Read();





            //2nd example
            //array, interface, class'lar ref type'dir
            //sonuc 1000 olmasının sebebi array'a new dedigimiz icin referans tipe döndü referans tiplilerde heap'te toplanır
            //new dedigimizde heap'te yeni veri olusuyor ve yeni veriye son verdigimiz değeri atıyor. Value Type'ın tam tersi.


            Person person1 = new Person();
            Person person2 = new Person();


            person1.FirstName = "Cem";
            person2 = person1;
            person1.FirstName = "Doruk";

            //Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Nehir";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Mehmet";


            Person person3 = customer;
            customer.FirstName = "Ahmet";
            //Console.WriteLine(person3.FirstName);
            //Console.WriteLine(((Customer)person3).CreditCardNumber);
            //Console.ReadLine();

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    //base class = person;

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person p)
        {
            Console.WriteLine(p.FirstName);
        }
    }
}
