using System;
using Xunit;
using Xunit.Sdk;
using CKK.Logic.Models;

namespace CKK.Test
{
    public class CKKTests
    {
        //[Fact]
        //public void AddItemGetItemStoreItem_ShouldAddProduct()
        //{
        //    try
        //    {
        //        //Assemble
        //        Customer customer = new Customer();
        //        ShoppingCart cart = new ShoppingCart(customer);
        //        //Act
                

        //        Assert.Equal();

        //    }
        //    catch
        //    {
        //        throw new XunitException("Not correct id");
        //    }
        //}

        //[Fact]
        //public void RemoveItemGetItemStoreItem_ShouldRemoveProduct()
        //{
        //    try
        //    {

        //    }
        //    catch
        //    {
        //        throw new XunitException("The Item Was not removed.");
        //    }
        //}

        [Fact]
        public void GetTotal_ShouldReturnCorrectValue()
        {
            try
            {
                Customer a = new Customer();
                Product y = new Product();
                y.SetId(5);
                y.SetName("y");
                y.SetPrice(25);
                Product u = new Product();
                y.SetId(6);
                y.SetName("u");
                y.SetPrice(56);
                ShoppingCart cart = new ShoppingCart(a);
                cart.AddProduct(y);
                cart.AddProduct(u);
                cart.GetProduct(1);


            }
            catch
            {
                throw new XunitException("The Correct Total Was not given.");
            }
        }
    }
}
