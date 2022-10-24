using System;
using Xunit;
using Xunit.Sdk;
using CKK.Logic.Models;

namespace CKK.Test
{
    public class CKKTests
    {
        [Fact]
        public void AddItemGetItemStoreItem_ShouldAddProduct()
        {
            try
            {
                //Assemble
                string expected = "exptected";
                Customer customer = new Customer();
                Product apple = new Product();
                apple.SetName(expected);
                ShoppingCart cart = new ShoppingCart(customer);
                //Act
                cart.AddProduct(apple);
                //Assert
                Assert.Equal(expected, cart.GetProduct(1).GetProduct().GetName());
            }
            catch
            {
                throw new XunitException("Not correct id");
            }
        }

        [Fact]
        public void RemoveItemGetItemStoreItem_ShouldRemoveProduct()
        {
            try
            {
                string expected = null;
                Customer customer = new Customer();
                Product apple = new Product();
                ShoppingCart cart = new ShoppingCart(customer);
                //Act
                cart.AddProduct(apple);
                cart.RemoveProduct(apple,2);
                //Assert
                Assert.Equal(expected, cart.GetProduct(1).GetProduct().GetName());
            }
            catch
            {
                throw new XunitException("The Item Was not removed.");
            }
        }

        [Fact]
        public void GetTotal_ShouldReturnCorrectValue()
        {
            try
            {
                decimal expected = 2;
                Customer a = new Customer();
                Product y = new Product();
                y.SetPrice(1);
                Product u = new Product();
                u.SetPrice(1);
                Product v = new Product();
                v.SetPrice(1);
                ShoppingCart cart = new ShoppingCart(a);
                cart.AddProduct(y);
                cart.AddProduct(u);

                decimal actual = cart.GetTotal();
                //Assert
                Assert.Equal(expected, actual);
            }
            catch
            {
                throw new XunitException("The Correct Total Was not given.");
            }
        }
    }
}
