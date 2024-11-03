using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
         static bool Isprime(int number)
        {
            if (number <=1)  {return false;}
            if (number == 2) { return true; }
            if (number % 2 == 0) { return false; }
            for (int i = 3; i < Math.Sqrt(number); i += 2) 
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first num: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second num: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int start = Math.Min(num1, num2);
            int end = Math.Max(num1, num2);
            Console.WriteLine("the prime numbers between "+start +" and "+ end+" is: ");
            for (int i = start ; i <= end ; i++)
			{
			 if (Isprime (i ))
             {
                 Console.Write(i +"  ");
             }
			}
            Console.ReadKey();
        }
           
            
            
        }
    }

