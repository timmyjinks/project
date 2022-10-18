using System;

namespace CKK.Logic.Models
{
    public class Product
    {
        private int _id;
        private string _name;
        private decimal _Price;

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

        public decimal GetPrice()
        {
            return _Price;
        }

        public void SetPrice(decimal Price)
        {
            _Price = Price;
        }
    }
}
