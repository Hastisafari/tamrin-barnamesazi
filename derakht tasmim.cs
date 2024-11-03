using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-have ever been to shiraz? (your answer must be yes or no!)");
            string input = Console.ReadLine();
            if (input.Equals("yes"))
            {
                Console.WriteLine("-was it beautiful there?");
                string a = Console.ReadLine();
                if (a.Equals("yes"))
                {
                    Console.WriteLine("-nice");
                }
                else
                {
                    Console.WriteLine("-can you tell me why? ");
                    string a1 = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("-would you like to travel to shiraz?");
                string b = Console.ReadLine();
                if (b.Equals("yes"))
                {
                    Console.WriteLine("-would you like to travel by plane?");
                    string b1 = Console.ReadLine();
                    if (b1.Equals("yes"))
                    {
                        Console.WriteLine("-are you booking a ticket to go to shiraz?");
                    }

                    else
                    {
                        Console.WriteLine("-what would you like to travel to shiraz with?");
                        string b2 = Console.ReadLine();
                        Console.WriteLine("-nice");
                    }


                }
                else
                { 
                    Console.WriteLine("-can you tell me why?");
                    string b3 = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }
    }
}
