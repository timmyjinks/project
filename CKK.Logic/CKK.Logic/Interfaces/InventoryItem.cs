using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    abstract public class InventoryItem
    {
        public Product _product { get; set; }
        private int quantity;
        public int _quantity
        {
            set
            {
                if(_quantity < 0)
                {
                    throw new InventoryStockToolLowException();
                }
                else { quantity = value; }
            }
            get
            {
                return quantity;
            }
        }
    }
}
