using System;
using Xunit;
using Xunit.Sdk;
using CKK.Logic.Models;

namespace CKK.Test
{
    public class UnitTest1
    {
        [Fact]
        public void AddItemGetItemStoreItem_ShouldAddProduct()
        {
            try
            {
                //Assemble
                Store store = new Store();
                Product product = new Product();
                Product expected = product;
                //Act
                store.AddStoreItem(product);
                Product actual = store.GetStoreItem(1);
                //Assert
                Assert.Equal(expected, actual);
                
            }
            catch
            {
                throw new XunitException("The product Was not added.");
            }
        }

        [Fact]
        public void RemoveItemGetItemStoreItem_ShouldRemoveProduct()
        {
            try
            {
                //Assemble
                Store store = new Store();
                Product product = new Product();
                Product expected = null;
                //Act
                store.AddStoreItem(product);
                store.RemoveStoreItem(1);
                Product actual = store.GetStoreItem(1);
                //Assert
                Assert.Equal(expected, actual);
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
                //Assemble
                Product product = new Product();
                product.SetPrice(5);
                ShoppingCartItem item = new ShoppingCartItem(product, 4);
                decimal expected = 20;
                //Act
                decimal actual = item.GetTotal();

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
