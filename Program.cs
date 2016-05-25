using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string userno;
            int user;
            Console.WriteLine("Enter the number");
            userno = Console.ReadLine();
            user = Convert.ToInt32(userno);
          
           
            if (user >= 0) {

                if(user == 0)
                {
                    Console.WriteLine("You just inputed zero");
                    Console.ReadLine();


                }
                else if (user % 2 == 0 && user % 4 == 0 && user % 8 == 0)
                {

                    Console.WriteLine("Its divisible");
                    Console.ReadLine();

                }
                else {

                    Console.WriteLine("Its not divisible");
                    Console.ReadLine();
                }
            
            }
            else {
            Console.WriteLine("Its less than zero");
                    Console.ReadLine();
            }
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
            Console.ReadLine();
               
            }
        
         /** Console.WriteLine("Hello World");
            //Console.ReadLine();
            //Console.WriteLine("Please type something and press the enter key.");
            //string userValue = Console.ReadLine();
            //Console.WriteLine("You typed: "+ userValue);
            //Console.ReadLine();
            //string userName;
            //Console.WriteLine("Please input your name: ");
            //userName = Console.ReadLine();
            //Console.WriteLine("Hi there, (0)")

            //rearrangingNames1
          string FirstName;
          string LastName;
          string MiddleInitial;
          Console.Write("Please input your first name: ");
          FirstName = Console.ReadLine();
          Console.Write("Please input your last name: ");
          LastName = Console.ReadLine();
          Console.Write("Please input your middle initial: ");
          MiddleInitial = Console.ReadLine();
          Console.WriteLine("Welcome, {0} {1} {2}! ", FirstName,MiddleInitial,LastName);
          Console.ReadLine();
          //rearrangingNames
            
            
            
            
            
            
            
            
          string FirstNamez;
          string LastNames;
          string MiddleInitials;
          Console.WriteLine("Please input your first name: ");
          FirstNamez = Console.ReadLine();
          Console.Write("Please input your last name: ");
          LastNames = Console.ReadLine();
          Console.Write("Please input your middle initial: ");
          MiddleInitials = Console.ReadLine();
          Console.WriteLine("Welcome, {0} {1} {2}! ", LastNames, FirstNamez, MiddleInitials);
          Console.ReadLine();**/
            


            // Adventure_Game
            //string person;
            //string occupation;
            //string seaCreature;
            //string animal;
            //string friend;
            //string tool;
            //string problem;
            //Console.WriteLine("Simple Adventure Game");
            //Console.Write("What is your name? ");
            //person = Console.ReadLine();
            //Console.Write("What is your occupation? ");
            //occupation = Console.ReadLine();
            //Console.Write("Please tell me your favorite animal: ");
            //animal = Console.ReadLine();
            //Console.Write("What is the name of one of your friends?");
            //friend = Console.ReadLine();
            //Console.Write("Name a problem you might face: ");
            //problem = Console.ReadLine();
            //Console.Write("Name a tool: ");
            //tool = Console.ReadLine();
            //Console.Write("Please give me the name of a sea creature: ");
            //seaCreature = Console.ReadLine();
            //Write the story
            //Console.WriteLine("One day there was a person named {0}. Now, {0} was usually ", person);
            //Console.WriteLine("very content to work as a {0}, but sometimes the job ", occupation);
            //Console.WriteLine("was extremely difficult.");
            //Console.WriteLine("One day, {0} discovered that the heartbreak of {1}  had ", person, problem);
            //Console.WriteLine("occurred just one time too often. \"I can't stand  being a ");
            //Console.WriteLine("{0} anymore!\" yelled {1}, as he hurled away his ", occupation, person);
            //Console.WriteLine("{0} in anger. No {1} will keep me from fulfilling", tool, problem);
            //Console.WriteLine("my dreams! What I really want, said {0}, is to be just like", person);
            //Console.WriteLine("{0}. Now THAT's somebody to admire. So {1} put away the ", friend, person);
            //Console.WriteLine("{0} forever, and followed {1} into the pastoral" , tool, friend);
            //Console.WriteLine("world of {0}−ranching. Eventually, {1} was able to ", animal, person);
            //Console.WriteLine("retire, as happy as a {0}", seaCreature);
            //Console.WriteLine();
            //Console.WriteLine();
            //    ask for Enter to quit
            //Console.Write("Please press Enter to continue");
            //Console.ReadLine();

        }
    }

