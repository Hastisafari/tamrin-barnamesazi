using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {
        static bool Ismirror(int number)
        {
            string strnumber = number.ToString();
            char[] chararray = strnumber.ToCharArray();
            Array.Reverse(chararray);
            string reversenum = new string(chararray);
            return strnumber == reversenum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first num: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second num: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int start = Math.Min(num1, num2);
            int end = Math.Max(num1, num2);
            Console.WriteLine("the mirror numbers between "+start +" and "+end +" is: ");
            for (int i = start; i < end; i++) 
            {
                if (Ismirror(i)) 
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
