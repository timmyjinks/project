using System;
using CKK.Logic.Models;

namespace CKKConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product();
            a.SetName("a");
            Product b = new Product();
            b.SetName("b");
            Product c = new Product();
            c.SetName("c");
            Product d = new Product();
            d.SetName("d");
            Customer customer = new Customer();
            ShoppingCart cart = new ShoppingCart(customer);
            for(int i = 0; i < 10;i++)
            {
                cart.AddProduct(a, 1);
            }
            for (int i = 0; i < 10; i++)
            {
                cart.AddProduct(b, 1);
            }
            for (int i = 0; i < 10; i++)
            {
                cart.AddProduct(c, 1);
            }
            for (int i = 0; i < 10; i++)
            {
                cart.AddProduct(d, 1);
            }


            foreach (var i in cart.GetProducts())
            {
                Console.WriteLine(i.GetProduct().GetName() + " || " + i.GetQuantity());
            }
            Console.WriteLine(cart.GetTotal());
        }
    }
}
