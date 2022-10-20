using System;
using CKK.Logic.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.SetId(456);
            Product a = new Product();
            a.SetId(1);
            a.SetName("dsljf");
            a.SetPrice(456);
            Product u = new Product();
            a.SetId(2);
            a.SetName("sdf");
            a.SetPrice(89);
            Product f = new Product();
            a.SetId(3);
            a.SetName("dsyjtyljf");
            a.SetPrice(56);
            Product test = new Product();
            a.SetId(4);
            a.SetName("test");
            a.SetPrice(56);
            ShoppingCart cart = new ShoppingCart(customer);
            cart.AddProduct(a,10);
            cart.AddProduct(u, 5);
            cart.AddProduct(f, 5);
            Console.WriteLine(cart.GetTotal());
        }
    }
}
