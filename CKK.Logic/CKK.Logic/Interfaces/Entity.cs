using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    abstract public class Entity
    {
        private int id;
        public int _id
        {
            set
            {
                if(id < 0)
                {
                    throw new InvalidException();
                }
                else
                {
                    id = value;
                }
            }
            get { return id; }
        }
        public string _name { get; set; }
    }
}
