using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Customer : Entity
    {
        private string _Address;
        public string Address
        {
            set
            {
                _Address = value;
            }
            get
            {
                return _Address;
            }
        }
    }
}