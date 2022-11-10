using System;
using CKK.Logic.Models;

namespace CKKConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product();
            a._name = "a";
            a._Price = 20;
            a._id = 1;
            Product b = new Product();
            b._name = "b";
            b._Price = 1;
            b._id = 2;
            Product c = new Product();
            c._name = "c";
            c._Price = 20;
            c._id = 3;
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
                Console.WriteLine(i._product._name + " || " + i._quantity);
            }
        }
    }
}
