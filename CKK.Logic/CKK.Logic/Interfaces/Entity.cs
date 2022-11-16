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
        private int _Id;
        public int Id
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ID");
                    throw new InvalidIdException();
                }
                else
                {
                    _Id = value;
                }
            }
            get { return _Id; }
        }

        private string _Name;
        public string Name
        {
            set
            {
                _Name = value;
            }
            get
            {
                return _Name;
            }
        }
    }
}