using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class BankAccount
    {
        private double balance;

        public void discount(double amount)
        {
                balance -= amount;
                Console.WriteLine(balance); 
        }
    }
}
