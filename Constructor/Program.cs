using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctor bir class'ı new dedigimiz zaman olusan bloklardır. ctor= yapıcı demek
            Customer customer1 = new Customer { Id = 1, FirstName = "Mehmet", LastName = "Yüksel", City = "Amasya" };

         

            Customer customer2 = new Customer ( 1, "Serhat", "Aşçı", "Sivas");
            Console.WriteLine(customer2.FirstName);


            Customer customer3 = new Customer();
            customer3.Id = 3;

            //ctor eğer method olarak kullanmak istersek eğer ctorun icine customer2'nin parametrelerini atarız
            //öyle yaparsak 1. tekrardan hata alır, hatayı düzeltmek ve hepsini kendi hallerinde yazmak icin bir tane daha ctor yaparız
        }
        
    }

    class Customer
    {
        public Customer() // parametresi olmayan constructorlar'a default ctor denilir.
        {

        }
        //default ctor (class ile aynı isimde olur)
        //Ctorlar method mantıgıyla calısır
        public Customer(int id, string firstname, string LastName, string city)
        {
            Id = id;
            FirstName = firstname;
            LastName = LastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
