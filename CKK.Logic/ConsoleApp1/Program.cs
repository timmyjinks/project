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
            a.SetId(2);
            a.SetName("sldkjf");
            a.SetPrice(1);
            Product u = new Product();
            u.SetId(1);
            u.SetName("tuetu");
            u.SetPrice(2);
            Product f = new Product();
            f.SetId(3);
            f.SetName("xcnvm");
            f.SetPrice(3);
            ShoppingCart cart = new ShoppingCart(customer);
            cart.AddProduct(a, 1);
            cart.AddProduct(u, 1);
            //cart.AddProduct(f, 1);
            Console.WriteLine(cart.GetCustomerId() + "\n" + cart.GetProductById(3).GetProduct().GetName() + "\n" + cart.GetTotal());
        }
    }
}
