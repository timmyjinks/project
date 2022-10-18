using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        ShoppingCart(Customer customer)
        {
            _customer = customer;
        }

        int GetCustomerId()
        {
            return _customer.GetId();
        }

        ShoppingCartItem GetProductById(int id)
        {
            return null;
        }

        ShoppingCartItem AddProduct(Product product)
        {
            return null;
        }

        ShoppingCartItem AddProduct(Product product, int quantity)
        {
            return null;
        }

        ShoppingCartItem RemoveProduct(Product product, int quantity)
        {
            return null;
        }

        decimal GetTotal()
        {
            return 0;
        }

        ShoppingCart GetProduct(int prodNum)
        {
            return null;
        }
    }
}
