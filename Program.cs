using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ifElse1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you prefer what is behind door number 1, 2, 3,4, 5 ");
            string exValue = Console.ReadLine();
            if (exValue == "1")
            {
                Console.WriteLine("You won a new Samsung 40 inch plasma tv");
                Console.ReadLine();
            }
            else if (exValue == "2")
            {
                Console.WriteLine("You won a new Haier Thermocool freezer");
                Console.ReadLine();
            }
            else if (exValue == "3")
            {
                Console.WriteLine("You won a new car");
                Console.ReadLine();

            }
            else if (exValue == "4")
            {
                Console.WriteLine("");
                Console.ReadLine();
            }
            else if (exValue == "5")
            {
                Console.WriteLine("You won a catoon of noodles");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("sorry, we didn't understand.  You lose!!!!!!!!");
                Console.ReadLine();
            }
        }
    }
}
