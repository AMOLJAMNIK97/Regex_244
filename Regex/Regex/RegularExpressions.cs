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
        
        Regex Firstname = new Regex("^[A-Z]{1}[a-z]{3}$");
        public void FirstName()
        {
            Console.WriteLine("Enter First Name");
            var data = Console.ReadLine();

            if (Firstname.IsMatch(data))
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
        Regex Lastname = new Regex("^[A-Z]{1}[a-z]{3}");
        public void LastName()
        {
            Console.WriteLine("Enter Last Name");
            var data = Console.ReadLine();

            if (Lastname.IsMatch(data))
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