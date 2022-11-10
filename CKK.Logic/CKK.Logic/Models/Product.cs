using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        private decimal Price;
        public decimal _Price 
        {
            set
            {
                if(Price < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else { Price = value; }
            }
            get
            {
                return Price;
            }
        }
    }
}
