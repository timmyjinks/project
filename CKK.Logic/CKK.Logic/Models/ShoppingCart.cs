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
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        public ShoppingCart(Customer customer)
        {
            _customer = customer;
        }

        public int GetCustomerId()
        {
            return _customer.GetId();
        }

        public ShoppingCartItem AddProduct(Product product)
        {
            int quantity;
            _product1 = new ShoppingCartItem(product,1);
             quantity = _product1.GetQuantity();
            _product1.SetQuantity(quantity++);
            return _product1;

            _product2 = new ShoppingCartItem(product, 1);
            quantity = _product1.GetQuantity();
            _product1.SetQuantity(quantity++);
            return _product2;

            _product3 = new ShoppingCartItem(product, 1);
            _product3.SetQuantity(quantity++);
            return _product3;
        }

        public ShoppingCartItem AddProduct(Product product, int quantity)
        {
            if (_product1 == null)
            {
                _product1 = new ShoppingCartItem(product, quantity);
                _product1.SetQuantity(quantity++);
                return _product1;
            }
            else if (_product2)
            {
                _product2 = new ShoppingCartItem(product, quantity);
                _product2.SetQuantity(quantity++);
                return _product2;
            }
            _product3 = new ShoppingCartItem(product, quantity);
            _product3.SetQuantity(quantity++);
            return _product3;
        }

        public ShoppingCartItem RemoveProduct(Product product, int quantity)
        {
            if (_product1 == null)
            {
                _product1.SetQuantity(quantity--);
                return _product1;
            }
            else if (_product2 == null)
            {
                _product2.SetQuantity(quantity--);
                return _product2;
            }
            else if (_product3 == null)
            {
                _product3.SetQuantity(quantity--);
                return _product3;
            }else { return null; }
        }

        public ShoppingCartItem GetProductById(int id)
        {
            //return _product1;
            //return _product2;
            return _product3;
        }

        public decimal GetTotal()
        {
            decimal prod1 = _product1.GetQuantity();

            return prod1;

        }

        public ShoppingCartItem GetProduct(int prodNum)
        {
            return _product1;
            return _product2;
            return _product3;
        }
    }
}
