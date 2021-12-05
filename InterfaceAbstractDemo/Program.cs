using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { DateofBirth=new System.DateTime(1995,7,20), FirstName="Cem Doruk", LastName="Gürsoy", NationalityId="1234567890"});


            Console.ReadLine();

        }
    }
}
