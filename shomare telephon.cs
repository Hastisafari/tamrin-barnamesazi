using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static bool contauntwodigit(string number)
        {
            HashSet<char> digits = new HashSet<char>(number);
            return digits.Count >= 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("matn mored nazar ra vared konid:");
            string input = Console.ReadLine();
            string pattern = @"(?<!\d)0\d{9}(?!\d)";
            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> validnumbers = new List<string>();
            foreach (Match  match in matches )
            {
                string number = match.Value;
                if (contauntwodigit(number)) 
                {
                    validnumbers.Add(number);
                }
            }
            if (validnumbers.Count > 0) 
            {
                Console.WriteLine("shomare telephon ha motabar ast!");
                foreach (string validnumber in validnumbers) ;
                {
                    Console.WriteLine(validnumbers+" ");
                }
            }
            else
            {
                Console.WriteLine("shomare motabar mojod nist!");
            }
            Console.ReadKey();
        }
    }
}
