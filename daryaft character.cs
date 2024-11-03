using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a character: ");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Length == 1)
                {
                    char character = input[0];
                    if (char.IsDigit(character))
                    {
                        Console.WriteLine("error! number is unavailable. please try again: ");
                    }
                    else
                    {
                        Console.WriteLine(character + " is your input.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
