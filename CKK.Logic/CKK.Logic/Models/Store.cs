using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private List<StoreItem> Items = new List<StoreItem>();

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

        //public StoreItem AddStoreItem(Product product, int quantity)
        //{
        //    if (_product1 == null)
        //    {
        //        _product1 = product;
        //    }else if(_product2 == null)
        //    {
        //        _product2 = product;
        //    }else if(_product3 == null)
        //    {
        //        _product3 = product;
        //    }else { Console.WriteLine("Full"); }
        //    return 
        //}

        //public StoreItem RemoveStoreItem(int id, int quantity)
        //{
        //    if (productNum == 1)
        //    {
        //        _product1 = null;
        //    }
        //    else if (productNum == 2)
        //    {
        //        _product2 = null;
        //    }else if (productNum == 3)
        //    {
        //        _product3 = null;
        //    }
        //}

        //public List<StoreItem> GetStoreItems()
        //{
        //    if(productNum == 1)
        //    {
        //        if (_product1 == null)
        //        {
        //            return null;
        //        }else { return _product1; }
        //    }else if(productNum == 2)
        //    {
        //        if(_product2 == null)
        //        {
        //            return null;
        //        }else { return _product2; }   
        //    }else if(productNum == 3)
        //    {
        //        if (_product3 == null)
        //        {
        //            return null;
        //        }else { return _product3; }
        //    }else { Console.WriteLine("Invalid");return null; }
        //}

        //public Product FindStoreItemById(int id)
        //{
        //    if (_product1.GetId() == id)
        //    {
        //        return _product1;
        //    }
        //    else if (_product2.GetId() == id)
        //    {
        //        return _product2;
        //    }
        //    else if (_product3.GetId() == id)
        //    {
        //        return _product3;
        //    }
        //    else { return null; }
        //}
    }
}