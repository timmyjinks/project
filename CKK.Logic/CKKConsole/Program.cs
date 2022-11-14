using System;
using CKK.Logic.Models;

namespace CKKConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product();
            a.Name = "a";
            a.Price = 20;
            a.Id = 1;
            Product b = new Product();
            b.Name = "b";
            b.Price = 1;
            b.Id = 2;
            Product c = new Product();
            c.Name = "c";
            c.Price = 20;
            c.Id = 3;
            Customer customer = new Customer();
            ShoppingCart cart = new ShoppingCart(customer);
            cart.AddProduct(b, 10);
            cart.AddProduct(a, 10);
            cart.AddProduct(c, 10);

            cart.AddProduct(a, 1);
            
            foreach (var i in cart.GetProducts())
            {
                Console.WriteLine(i.Product.Name + " || " + i.Quantity + "||" + cart.GetProductById(0).Product.Price);
            }
        }
    }
}
