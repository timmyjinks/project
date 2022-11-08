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
            cart.AddProduct(a, 10);
            cart.AddProduct(b, 10);
            cart.AddProduct(c, 10);

            cart.RemoveProduct(1, 20);
            cart.RemoveProduct(2, 9);
            cart.RemoveProduct(3, 8);
            cart.AddProduct(a, 1);
            foreach (var i in cart.GetProducts())
            {
                Console.WriteLine(i.GetProduct().GetName() + " || " + i.GetQuantity());
            }
            //Console.WriteLine(cart.FindStoreItemById(2).GetProduct().GetName());
        }
    }
}
