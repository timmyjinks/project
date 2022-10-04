using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    class Product
    {
        private int _id;
        private string _name;
        private double _Price;

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

        public double GetPrice()
        {
            return _Price;
        }

        public void SetPrice(double Price)
        {
            _Price = Price;
        }
    }
}
