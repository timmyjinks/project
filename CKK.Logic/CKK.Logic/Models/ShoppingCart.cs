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

        public ShoppingCartItem GetProductById(int id)
        {
            if (_product1.GetProduct().GetId() == id)
            {
                return _product1;
            }
            if (_product2.GetProduct().GetId() == id)
            {
                return _product2;
            }
            if (_product3.GetProduct().GetId() == id)
            {
                return _product3;
            }
            else { return null; }
        }

        public ShoppingCartItem AddProduct(Product product)
        {
            int quantity = 1;
            if (_product1 == null)
            {
                _product1 = new ShoppingCartItem(product, quantity);
                return _product1;
            }
            else if (_product2 == null && _product1.GetProduct() != product)
            {
                _product2 = new ShoppingCartItem(product, quantity);
                return _product2;
            }
            else if (_product3 == null && _product1.GetProduct() != product && _product2.GetProduct() != product)
            {
                _product3 = new ShoppingCartItem(product, quantity);
                return _product3;
            }
            else if (_product1.GetProduct() == product)
            {
                quantity = _product1.GetQuantity() + 1;
                _product1.SetQuantity(quantity);
                return _product1;
            }
            else if (_product2.GetProduct() == product)
            {
                quantity = _product2.GetQuantity() + 1;
                _product2.SetQuantity(quantity);
                return _product2;
            }
            else if (_product3.GetProduct() == product)
            {
                quantity = _product3.GetQuantity() + 1;
                _product3.SetQuantity(quantity);
                return _product3;
            }
            else { return null; }
        }

        public ShoppingCartItem AddProduct(Product product, int quantity)
        {
            if (quantity > 0)
            {
                if (_product1 == null)
                {
                    _product1 = new ShoppingCartItem(product, quantity);
                    return _product1;
                }
                else if (_product2 == null && _product1.GetProduct() != product)
                {
                    _product2 = new ShoppingCartItem(product, quantity);
                    return _product2;
                }
                else if (_product3 == null && _product1.GetProduct() != product && _product2.GetProduct() != product)
                {
                    _product3 = new ShoppingCartItem(product, quantity);
                    return _product3;
                }
                else if (_product1.GetProduct() == product)
                {
                    quantity = _product1.GetQuantity() + quantity;
                    _product1.SetQuantity(quantity);
                    return _product1;
                }
                else if (_product2.GetProduct() == product)
                {
                    quantity = _product2.GetQuantity() + quantity;
                    _product2.SetQuantity(quantity);
                    return _product2;
                }
                else if (_product3.GetProduct() == product)
                {
                    quantity = _product3.GetQuantity() + quantity;
                    _product3.SetQuantity(quantity);
                    return _product3;
                }
                else { return null; }
            }
            else { return null; }
        }

        public ShoppingCartItem RemoveProduct(Product product, int quantity)
        {
            if (_product1.GetProduct() == product)
            {
                if (_product1.GetQuantity() > 0)
                {
                    if (_product1.GetQuantity() - quantity < 1)
                    {
                        _product1.SetQuantity(0);
                        return null;
                    }
                    else { int temp = _product1.GetQuantity() - quantity; _product1.SetQuantity(temp); return _product1; }
                }
                else { return null; }
            }
            else if (_product2.GetProduct() == product)
            {
                if (_product2.GetQuantity() > 0)
                {
                    if (_product2.GetQuantity() - quantity < 1)
                    {
                        _product2.SetQuantity(0);
                        return null;
                    }
                    else { int temp = _product2.GetQuantity() - quantity; _product2.SetQuantity(temp); return _product2; }
                }
                else { return null; }
            }
            else if (_product3.GetProduct() == product)
            {
                if (_product3.GetQuantity() > 0)
                {
                    if (_product3.GetQuantity() - quantity < 1)
                    {
                        _product3.SetQuantity(0);
                        return null;
                    }
                    else { int temp = _product3.GetQuantity() - quantity; _product3.SetQuantity(temp); return _product3; }
                }
                else { return null; }
            }
            else { return null; }
        }

        public decimal GetTotal()
        {
            if (_product1 != null && _product2 != null && _product3 != null)
            {
                return _product1.GetTotal() + _product2.GetTotal() + _product3.GetTotal();
            }else if (_product1 != null && _product2 != null)
            {
                return _product1.GetTotal() + _product2.GetTotal();
            }else if(_product1 != null && _product3 != null)
            {
                return _product1.GetTotal() + _product3.GetTotal();
            }else if(_product2 != null && _product3 != null)
            {
                return _product2.GetTotal() + _product3.GetTotal();
            }else if (_product1 != null)
            {
                return _product1.GetTotal();
            }else if(_product2 != null)
            {
                return _product2.GetTotal();
            }else if(_product3 != null)
            {
                return _product3.GetTotal();
            }
            else { return 0; }
        }

        public ShoppingCartItem GetProduct(int prodNum)
        {
            if (prodNum == 1)
            {
                return _product1;
            }
            else if (prodNum == 2)
            {
                return _product2;
            }
            else if (prodNum == 3)
            {
                return _product3;
            }
            else { return null; }
        }
    }
}