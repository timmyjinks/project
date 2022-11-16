using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
    {
        public Customer Customer { get; set; }
        public List<ShoppingCartItem> Products = new List<ShoppingCartItem>();

        public ShoppingCart(Customer customer)
        {
            Customer = customer;
        }

        public int GetCustomerId()
        {
            return Customer.Id;
        }

        public ShoppingCartItem AddProduct(Product product, int quantity)
        {
            var q =
                from i in Products
                where i.Product == product
                select i;
            if (quantity <= 0)
            {
                Console.WriteLine("ShoppingCartAdd");
                throw new InventoryItemStockTooLowException();
            }
            else
            {
                if (Products.Count() == 0)
                {
                    Products.Add(new ShoppingCartItem(product, quantity));
                    return Products[0];
                }else if (Products.Count != 0)
                {
                    int count = 0;
                    foreach (var prod in Products)
                    {
                        count++;
                        if (prod.Product == product)
                        {
                            foreach (var obj in q)
                            {
                                quantity = obj.Quantity + quantity;
                                obj.Quantity = quantity;
                            }return null;
                        }else if (Products.Count() == count)
                        {
                            Products.Add(new ShoppingCartItem(product, quantity));
                            return prod;
                        }
                    }return null;
                }else { return null; }
            }
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            var q =
                from i in Products
                where i.Product.Id == id
                select i;
            if (quantity < 0)
            {
                Console.WriteLine("ShoppingCartRemoveQ");
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                foreach (var prod in q)
                {
                    if (prod.Quantity - quantity < 1 || prod.Product == null || prod.Quantity == 0)
                    {
                        Products.Remove(prod);
                        prod.Quantity = 0;
                        return prod;
                    }
                    else
                    {
                        quantity = prod.Quantity - quantity;
                        prod.Quantity = quantity;
                        return prod;
                    }
                }Console.WriteLine("ShoppingCartRemoveP"); throw new ProductDoesNotExistException();
            }
        }

        public decimal GetTotal()
        {
            int count = 1;
            decimal quantity = 0;
            foreach (var prod in Products)
            {
                quantity = prod.GetTotal() + quantity;
                if (count == Products.Count())
                {
                    return quantity;
                }
                count++;
            }return 0;
        }

        public List<ShoppingCartItem> GetProducts()
        {
            return Products;
        }

        public ShoppingCartItem GetProductById(int id)
        {
            var q =
                from i in Products
                where i.Product.Id == id
                select i;
            if (id < 0)
            {
                Console.WriteLine("ShoppingCartId");
                throw new InvalidIdException();
            }
            else
            {
                foreach (var i in q)
                {
                    return i;
                }
                return null;
            }
        }
    }
}