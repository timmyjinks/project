using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class Store
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

        }

        public void RemoveStoreItem(int productNum)
        {

        }

        public Product GetStoreItem(int productNum)
        {
            return _product1;
        }

        public Product FindStoreItemById(int id)
        {
            return _product1;
        }
    }
}
