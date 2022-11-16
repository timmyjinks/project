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
        private Product _Product;
        public Product Product
        {
            set
            {
                _Product = value;
            }
            get
            {
                return _Product;
            }
        }

        private int _Quantity;
        public int Quantity
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Quantity");
                    throw new InventoryItemStockTooLowException();
                }else { _Quantity = value; }
            }
            get
            {
                return _Quantity;
            }
        }
    }
}