using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //first way
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //second way
            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Pencil", UnitsInStock = 5, UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



        }
    }
}
