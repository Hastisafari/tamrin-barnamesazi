using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        static bool Isfibo(int n)
        {
            int a = 0;
            int b = 1;
            while (b < n) 
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return n == b || n == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (Isfibo(num)) 
            {
                Console.WriteLine(num+" is fibo");
            }
            else
                Console.WriteLine(num +" is not fibo");
            Console.ReadKey();
        }
    }
}
