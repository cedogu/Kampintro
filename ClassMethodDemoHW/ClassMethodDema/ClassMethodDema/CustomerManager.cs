using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDema
{
    class CustomerManager
    {
        public void Add(Customer c)
        {
            Console.WriteLine("Customer Information: " + c.CustomerName, c.CustomerSurname, c.CustomerOccupation);
        }
        public void Delete(Customer c)
        {
            Console.WriteLine("Customer Deleted " + c.CustomerName, c.CustomerSurname, c.CustomerOccupation);
        }
    }
}
