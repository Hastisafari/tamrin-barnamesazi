using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter a number: ");
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse (input ,out number ))
                {
                    Console.WriteLine("your number is "+number  );
                    break;
                }
                else
                    Console.WriteLine("you enter the wrong character. please try again: ");
            }
            Console.ReadKey();
        }
    }
}
