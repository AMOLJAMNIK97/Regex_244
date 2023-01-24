using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    public class RegularExpressions
    {
        
        Regex regex = new Regex("^[A-Z]{1}[a-z]{3}$");
        public void FirstName()
        {
            Console.WriteLine("Enter First Name");
            var data = Console.ReadLine();

            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " is Not Valid");
                Console.ResetColor();
            }
        }
    }
}