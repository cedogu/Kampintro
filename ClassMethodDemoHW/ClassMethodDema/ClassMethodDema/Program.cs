using System;

namespace ClassMethodDema
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Cem Doruk";
            customer1.CustomerSurname = "Gürsoy";
            customer1.CustomerOccupation = " Pilot";

            Customer customer2 = new Customer();

            customer2.CustomerId = 2;
            customer2.CustomerName = "Nehir";
            customer2.CustomerSurname = "Gül";
            customer2.CustomerOccupation = " Lawyer";

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (var mycustomer in customers)
            {
                Console.WriteLine(mycustomer.CustomerName + " " + mycustomer.CustomerSurname + "" + mycustomer.CustomerOccupation);
            }
            Console.WriteLine("----------------");


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer1);

            customerManager.Add(customer2);
            customerManager.Delete(customer2);


            Console.ReadLine();
        }
    }
}
