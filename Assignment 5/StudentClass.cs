using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class StudentClass
    {
        public int _Id { get; set; }
        public string? _Name { get; set; }

        public StudentClass(int Id, string Name)
        {
            _Id = Id;
            _Name = Name;
        }
    }
}
