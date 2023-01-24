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
        Regex EmailID = new Regex("^[0-9A-Za-z]+([.][0-9A-Za-z]+)[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})$");
        public void CheckEmailId()
        {
            Console.WriteLine("Enter Eamil ID ");
            var data = Console.ReadLine();

            if (EmailID.IsMatch(data))
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
        Regex PhoneNumber = new Regex("^[6-9]{1}[0-9]{9}$");
        public void CheckPhoneNumber()
        {
            Console.WriteLine("Enter Phone Number ");
            var data = Console.ReadLine();

            if (PhoneNumber.IsMatch(data))
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
        Regex Pass = new Regex("^[A-Z]{1}[a-z]{3}[0-9]{3,}$");
        public void PassWord()
        {
            Console.WriteLine("Enter PassWord ");
            var data = Console.ReadLine();

            if (Pass.IsMatch(data))
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