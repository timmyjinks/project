using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private List<ShoppingCartItem> Products = new List<ShoppingCartItem>();

        public ShoppingCart(Customer customer)
        {
            _customer = customer;
    }

        public int GetCustomerId()
        {
            return _customer.GetId();
        }

        public ShoppingCartItem GetProductById(int id)
        {
            return null;
        }

        public ShoppingCartItem AddProduct(Product product, int quantity)
        {
            var q =
                from i in Products
                where i.GetProduct() == product
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
                        if (prod.GetProduct() == product)
                        {
                            foreach (var obj in q)
                            {
                                quantity = obj.GetQuantity() + quantity;
                                obj.SetQuantity(quantity);
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
            }else { return null; }
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            var q =
                from i in Products
                where i.GetProduct().GetId() == id
                select i;
            foreach(var prod in q)
            {
                if (prod.GetQuantity() - quantity < 1)
                {
                    Products.Remove(prod);
                    prod.SetQuantity(0);
                    return prod;
                }else if(prod.GetProduct() == null || prod.GetQuantity() == 0)
                {
                    Products.Remove(prod);
                    return prod;
                }
                else
                {
                    quantity = prod.GetQuantity() - quantity;
                    prod.SetQuantity(quantity);
                    return null;
                }
            }return null;
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