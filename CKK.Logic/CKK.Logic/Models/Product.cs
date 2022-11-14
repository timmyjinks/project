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
        private decimal _Price;
        public decimal Price 
        {
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else { _Price = value; }
            }
            get
            {
                return _Price;
            }
        }
    }
}
