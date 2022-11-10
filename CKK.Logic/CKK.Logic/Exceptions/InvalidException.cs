using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    [Serializable]
    class InvalidException : Exception
    {
        public InvalidException() : base() 
        {
            Console.WriteLine("Invalid Value");
        }
    }
}
