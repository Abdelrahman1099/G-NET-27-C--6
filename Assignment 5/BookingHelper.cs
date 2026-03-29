using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    static class BookingHelper
    {
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;

            if (numberOfTickets >= 5)
            {
                return total * 0.90;
            }
            return total;
        }

        private static int counter = 0;
   

   public static string GenerateBookingReference()
        {
            counter++;
            return "BK_" + counter;

        }
    }
}
