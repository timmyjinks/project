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
        private List<ShoppingCartItem> Products = new List<ShoppingCartItem>();

        public ShoppingCart(Customer customer)
        {
            Customer = customer;
    }

        public int GetCustomerId()
        {
            return Customer._id;
        }

        public ShoppingCartItem GetProductById(int id)
        {
            var q =
                from i in Products
                where i._product._id == id
                select i;
            if (id > 0)
            {
                foreach (var i in q)
                {
                    return i;
                }return null;
            }
            else { throw new InvalidException(); }
        }

        public ShoppingCartItem AddProduct(Product product, int quantity)
        {
            var q =
                from i in Products
                where i._product == product
                select i;
            if (quantity > 0)
            {
                if(Products.Count() == 0)
                {
                    Products.Add(new ShoppingCartItem(product, quantity));
                    return Products[0];
                }
                else if (Products.Count != 0)
                {
                    int count = 0;
                    foreach (var prod in Products)
                    {
                        count++;
                        if (prod._product == product)
                        {
                            foreach (var obj in q)
                            {
                                quantity = obj._quantity + quantity;
                                obj._quantity = quantity;
                            }
                            return null;
                        }
                        else if (Products.Count() == count)
                        {
                            Products.Add(new ShoppingCartItem(product, quantity));
                            return prod;
                        }
                    }return null;
                }else { return null; }
            }else { throw new InventoryStockToolLowException(); }
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            var q =
                from i in Products
                where i._product._id == id
                select i;
            if (quantity > 0)
            {
                foreach (var prod in q)
                {
                    if (prod._quantity - quantity < 1)
                    {
                        Products.Remove(prod);
                        prod._quantity = 0;
                        return prod;
                    }
                    else if (prod._quantity == 0)
                    {
                        Products.Remove(prod);
                        return prod;
                    }
                    else if(prod._product == null)
                    {
                        throw new ProductDoesNotExistException();
                    }
                    else
                    {
                        quantity = prod._quantity - quantity;
                        prod._quantity = quantity;
                        return null;
                    }
                }
                return null;
            }
            else { throw new ArgumentOutOfRangeException(); }
        }

        public decimal GetTotal()
        {
            var total =
                from i in Products
                let value = i.GetTotal()
                select value;
            foreach (var prod in total)
            {
                return prod; 
            }
            return 0;
        }

        public List<ShoppingCartItem> GetProducts()
        {
            return Products;
        }

        public ShoppingCartItem FindStoreItemById(int id)
        {
            return Products[id];
        }
    }
}