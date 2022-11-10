﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    [Serializable]
    class ProductDoesNotExistException : Exception
    {
        public ProductDoesNotExistException() : base() 
        {
            Console.WriteLine("Product No Exist");
        }
    }
}