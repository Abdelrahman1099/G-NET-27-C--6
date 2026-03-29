using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Ticket
    {
        private string _MovieName;
        public TicketType _Type { get; set; }
        public SeatLocation _Seat { get; set; }
        private double _Price;
        private static int _ticketCounter = 0;
        public int _TicketId { get; private set; }

        public string MovieName { get { return _MovieName; } set { if (!string.IsNullOrWhiteSpace(value)) { _MovieName = value; } } }
        public double price { get { return _Price; } set { if (value > 0) { _Price = value; } } }
        public double PriceAfterTax => _Price * 1.14;
        

        public Ticket (string MovieName, TicketType Type, SeatLocation Seat, double Price)
        {
            _MovieName = MovieName; 
            _Type = Type;   
            _Seat = Seat; 
            this._Price = Price;
        }

        public Ticket (string MovieName) : this(MovieName, TicketType.Standard, new SeatLocation('A', 1), 50) 
        { 

        }

        public double CalcTotal(double taxPercent) 
        {

           return _Price + (_Price * taxPercent / 100);
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= _Price)
            {
                _Price -= discountAmount;
                discountAmount = 0;
            } 
      
        }

       public void PrintTicket(double taxPercent)
        {
            Console.WriteLine($"Movie : {_MovieName}");
            Console.WriteLine($"Type : {_Type}");
            Console.WriteLine($"Seat : {_Seat}");
            Console.WriteLine($"Price : {_Price}");
            Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent)}");
        }




        public Ticket()
        {
            _ticketCounter++;
            _TicketId = _ticketCounter;
        }


        public static int GetTotalTicketsSold()
        {
            return _ticketCounter;
        } 
        


    }
}
