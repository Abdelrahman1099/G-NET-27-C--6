using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal struct SeatLocation
    {
        public char _row;
        public int _number;

        public SeatLocation(char row, int number)
        {
            _row = row;
            _number = number;
        }
    }
}
