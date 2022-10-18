using System;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void AddStoreItem(Product prod)
        {
            if (_product1 == null)
            {
                _product1 = prod;
            }else if(_product2 == null)
            {
                _product2 = prod;
            }else if(_product3 == null)
            {
                _product3 = prod;
            }else { Console.WriteLine("Full"); }
        }

        public void RemoveStoreItem(int productNum)
        {
            if (productNum == 1)
            {
                _product1 = null;
            }
            else if (productNum == 2)
            {
                _product2 = null;
            }else if (productNum == 3)
            {
                _product3 = null;
            }
        }

        public Product GetStoreItem(int productNum)
        {
            if(productNum == 1)
            {
                if (_product1 == null)
                {
                    return null;
                }else { return _product1; }
            }else if(productNum == 2)
            {
                if(_product2 == null)
                {
                    return null;
                }else { return _product2; }   
            }else if(productNum == 3)
            {
                if (_product3 == null)
                {
                    return null;
                }else { return _product3; }
            }else { Console.WriteLine("Invalid");return null; }
        }

        public Product FindStoreItemById(int id)
        {
            return null;
        }
    }
}