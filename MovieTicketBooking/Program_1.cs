using System;

namespace MovieTicketBooking
{
    class TotalTickets
    {
        public void Category()
        {
            bool count = true;
            bool count1 = true;
            int sumTicket = 0;
            string cat = null;
            Console.WriteLine("___________List of category__________");
            Console.WriteLine("Thriller = 'T'\nAction = 'A'\nDrama = 'D'\nComedy = 'C'");


            while (count)
            {
                Console.Write("\nPlease choose a category : ");
                cat = Console.ReadLine();

                if (cat == "t" || cat == "T")
                {
                    Console.WriteLine(" ===== Availability of the tickets =====\nThriller = " + Thriller());
                    cat = "Thriller";
                    count = false;
                }
                else if (cat == "a" || cat == "A")
                {
                    Console.WriteLine(" ===== Availability of the tickets =====\nAction = " + Action());
                    cat = "Action";
                    count = false;
                }
                else if (cat == "d" || cat == "D")
                {
                    Console.WriteLine(" ===== Availability of the tickets =====\nDrama = " + Drama());
                    cat = "Drama";
                    count = false;
                }
                else if (cat == "c" || cat == "C")
                {
                    Console.WriteLine(" ===== Availability of the tickets =====\nComedy = " + Comedy());
                    cat = "Comedy";
                    count = false;
                }
                else
                {
                    Console.WriteLine("\n======= Please enter a valid key ======");
                }
            }

            while (count1)
            {
                try
                {
                    Console.Write("\nHow many tickets : ");
                    sumTicket = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("\n____________Please enter an integer number___________");
                }


                if (sumTicket > Action() || sumTicket < 1)
                {
                    Console.WriteLine("Sorry!, the selected number of tickets are out of range of availability.");
                    bool count2 = true;
                    while (count2)
                    {
                        Console.Write("Do you wanna continue? y/n:");
                        string choice2 = Console.ReadLine();
                        if (choice2 == "y" || choice2 == "Y")
                        {
                            count2 = false;
                        }
                        else if (choice2 == "n" || choice2 == "N")
                        {
                            Console.WriteLine("Thank you for using our system.");
                            count1 = false;
                            count2 = false;
                        }
                        else
                        {
                            Console.WriteLine("=======Please enter a valid key======");
                        }
                    }
                }
                else
                {

                    Console.Write("You have choosen " + sumTicket + " tickets of category '" + cat + "'\nPlease enter your name : ");
                    string name = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(sumTicket + " tickets of category-"+cat+" have been booked successfully by " + name.ToUpper());
                    Console.ForegroundColor = ConsoleColor.Gray;
                    count1 = false;

                }
            }
        }
        public int Thriller()
        {
            int thrill = 20;
            return thrill;
        }
        public int Action()
        {
            int action = 20;
            return action;
        }
        public int Drama()
        {
            int drama = 20;
            return drama;
        }
        public int Comedy()
        {
            int comedy = 20;
            return comedy;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~ Welcome to Movie Ticket Booking system ~~~~~~~\n");
            //TotalTickets tickets = new TotalTickets();
            bool count = true;
            string choice = null;
            while (count)
            {
                Console.Write("Do you want to book a ticket?\nPlease Enter 'Y' for YES and 'N' for NO : ");
                choice = Console.ReadLine();

                if (choice == "y" || choice == "Y")
                {
                    TotalTickets newTicket = new TotalTickets();
                    newTicket.Category();
                    
                    count = false;
                }
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("Thank you for using our system.");
                    count = false;
                }
                else
                {
                    Console.WriteLine("=======Please enter a valid key======");
                }
            }
            Console.WriteLine("\n~~~~~~~ Have a nice day!!! ~~~~~~~");
        }
    }
}
