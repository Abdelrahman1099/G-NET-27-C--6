using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal struct StudentStruct
    {
        public int Id;
        public string Name;

        public StudentStruct (int id, string name)
        {
            Id = id;    
            Name = name;
        }
    }
}
