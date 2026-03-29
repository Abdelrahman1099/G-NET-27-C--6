using System.Diagnostics;
using System.Globalization;
using System.Threading.Channels;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 

            // Q1 : Explain with code example how class and struct behave differently.

            // Class: is a reference type. It lives on the Heap When you pass it around you are passing a pointer to the data.
            // Struct: is a value Type. It lives on the Stack When you pass it around you are passing a copy of the data.
            // Behavior in class if you change a property in a copied class the original changes too. if you change a property in a copied struct the original stays the same.

            //StudentClass class1 = new StudentClass(10, "Ahmed");
            //StudentClass class2 = class1;
            //Console.WriteLine(class1._Name);
            //Console.WriteLine(class2._Name);

            //class2._Name = "Ziad";

            //Console.WriteLine(class1._Name);
            //Console.WriteLine(class2._Name);


            //StudentStruct struct1 = new StudentStruct(20, "Mohamed");
            //StudentStruct struct2 = struct1;
            //Console.WriteLine(struct1.Name);
            //Console.WriteLine(struct2.Name);

            //struct2.Name = "Nada"; 

            //Console.WriteLine(struct1.Name);
            //Console.WriteLine(struct2.Name);

            #endregion

            #region 

            // Q2 : Explain the difference between public and private access modifiers with an example.

            // A public member can be accessed from anywhere in the program, while a private member can only be accessed inside the same class.

            //BankAccount account = new BankAccount();
            //account.discount(20000);
            //account.balance

            #endregion

            #region 

            // Q3 : Describe the steps to create and use a class library in Visual Studio.

            // open Visual Studio and select Create a new project, then choose Class Library and click Create. After the project is created, 
            // add your classes and write the code you want to reuse next, build the project to generate the DLL file. to use this class library in another project.

            #endregion

            #region 

            // Q4 : What is a class library? Why do we use class libraries?

            // A class library is a collection of reusable classes, methods, and functions that are compiled into a DLL file and can be used by other projects,
            // We use class libraries to organize code, avoid repetition, and make applications easier to maintain and manage.
            #endregion

            #region 

            // Movie Ticket Booking System.

            // Each ticket has a type that can only be one of: Standard, VIP, or IMAX. How would you represent this?

            // The most appropriate way to represent specific choices is Enum.

            // You need a type to represent a seat location (Row as a char like 'A', 'B', and Number as an int). Should this be a class or a struct? Create it.

            // as data is simple and light, it is best to use Struct. 

            //Console.Write("Enter Movie Name : ");
            //string name = Console.ReadLine();

            //Console.Write("Enter Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX) : ");
            //TicketType type = (TicketType) int.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Row (A, B, C...): ");
            //char row = char.Parse(Console.ReadLine().ToUpper());

            //Console.Write("Enter Seat Number : ");
            //int seatNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter Price : ");
            //double price = double.Parse(Console.ReadLine());

            //Console.Write("Enter Discount Amount : ");
            //double discount = double.Parse(Console.ReadLine());

            //Ticket ticket = new Ticket(name, type, new SeatLocation(row, seatNum), price);

            //double tax = 15.0;

            //Console.WriteLine("===== Ticket Info =====");
            //ticket.PrintTicket(tax);

            //Console.WriteLine("===== After Discount =====");
            //Console.WriteLine($"Discount Before : {discount}");

            //ticket.ApplyDiscount(ref discount);
            //Console.WriteLine($"Discount After  : {discount}");

            //ticket.PrintTicket(tax);

            #endregion


            // Assignment 2


            #region 

            // Q1 : Consider the following class:

            // a) problems is the fields are public, and there is no validation logic in the withdraw method.
            // b) we can fix the fields by making them (private) and use properties for acess, and check withdraw to ensure amount <= balance.
            // c) direct acess prevents data validation and make the code hard to maintain or protect.

            #endregion

            #region 

            //  Q02 : What is the difference between a field and a property in C#? Can a property contain logic?
            //  Give an example of a read-only property that returns a calculated value.

            // the field is a variable inside a class, the property is a member that can read or write fields values via (get) and (set) accessors,
            // and can contain logic (validation, formating).
            // read only examle : public int age => DateTime.year - birthyear; 

            #endregion

            #region 

            // Q3 : Look at the following code and answer the questions below:

            // a) it is called an indexer, it allows instances of a class to be indexed like arrays.
            // b) it cause an indexOutOfRangeExeption. to make it safer we can add (if) statment to check if the index is within the valid range.
            // c) yes, via overloading.
            // example : you could have one indexer that takes an int (position) and another that takes a string (student name).

            #endregion

            #region 

            // Q4 : Consider the following code and answer the questions below:

            // a) static meaning it belongs to the class itself, only one copy exists in memory shared by all instance.
            // the difference that the totalorders is shared across all objects, while (item) is unique to each individual object.
            // b) no, a static method belongs to the class and does not have acess to a specific object's instance data.
            // it requires an object to exists before it can be accessed.

            #endregion

            #region 

            Cinema cinema = new Cinema();
            Console.WriteLine("====== Ticket Booking ======");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter data for Ticket {i}:");

                Ticket t = new Ticket();

                Console.WriteLine("Movie Name: ");
                t.MovieName = Console.ReadLine();

                Console.WriteLine("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
                int input = int.Parse(Console.ReadLine());
                t._Type = (TicketType)input;

                Console.Write("Seat Row (A-Z): ");
                char roww = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Seat Number: ");
                int num = int.Parse(Console.ReadLine());
                t._Seat = new SeatLocation(roww, num);

                Console.Write("Price: ");
                t.price = double.Parse(Console.ReadLine());

                cinema.AddTicket(t);
            }

            Console.WriteLine("====== All Tickets ======");

            for (int j = 0; j < 3; j++) 
            {
                Ticket temp = cinema[j];

                Console.WriteLine($"#{temp._TicketId} | {temp.MovieName} | seat: {temp._Seat._row}-{temp._Seat._number} price {temp.price} EGP");
            }

            Console.WriteLine("======== Search by Movie ========");
            Console.Write("Enter movie name to search: ");

            string search = Console.ReadLine();
            Ticket found = cinema.GetMovieByName(search);
            Console.WriteLine($"Found: Ticket #{found._TicketId} | {found.MovieName} | {found._Type} | seat: {found._Seat._row}-{found._Seat._number} | price: {found.price} EGP");

            Console.WriteLine("========Statistics ========");
            Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

            Console.WriteLine($"Booking Reference 1: {BookingHelper.GenerateBookingReference()}");
            Console.WriteLine($"Booking Reference 2: {BookingHelper.GenerateBookingReference()}");

            double groupPrice = BookingHelper.CalcGroupDiscount(5, 80);
            Console.WriteLine($"Group Discount (5 tickets x 80 EGP): {groupPrice} EGP (10% off applied)");

            #endregion

        }
    }
}
