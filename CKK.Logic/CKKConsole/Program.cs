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
            a.SetPrice(20);
            a.SetId(1);
            Product b = new Product();
            b.SetName("b");
            b.SetPrice(1);
            b.SetId(2);
            Product c = new Product();
            c.SetName("c");
            c.SetPrice(2);
            c.SetId(3);
            Product d = new Product();
            d.SetName("d");
            d.SetPrice(10);
            d.SetId(4);
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
            cart.AddProduct(a, 0);

            foreach (var i in cart.GetProducts())
            {
                Console.WriteLine(i.GetProduct().GetName() + " || " + i.GetQuantity());
            }
            Console.WriteLine(cart.GetTotal());
        }
    }
}
