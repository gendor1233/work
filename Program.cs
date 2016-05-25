using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_IfElse2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Type in a number from 1 to 5");
            string userInput = Console.ReadLine();
            string message = "";
            if (userInput == "1")
            {
                message = "You typed in ONE";
            }
            else if (userInput == "2")
            {
                message = "You typed in TWO";
            }
            else if (userInput == "3")
            {
                message = "You typed in THREE";
            }
            else if (userInput == "4")
            {
                message = "You typed in FOUR";
            }
            else if (userInput == "5")
            {
                message = "You typed in FIVE";
            }
            else 
            {
                message = "Invalid input.. You Lose!!!!";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            }
        }
    }

