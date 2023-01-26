using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Regular Expressions Program");
            RegularExpressions regular = new RegularExpressions();
            Console.WriteLine("1.Enter the First Name \n2.Enter the Last Name\n3.Email ID\n4.Enter Phone Number\n5.Enter PassWord \n6.Pass Rule4\n7.Check Email vaild");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    regular.FirstName();
                    break;
                case 2:
                    regular.LastName();
                    break;
                case 3:
                    regular.CheckEmailId();
                    break;
                case 4:
                    regular.CheckPhoneNumber();
                    break;
                case 5:
                    regular.PassWord();
                    break;
                case 6:
                    regular.RulePass();
                    break;
                case 7:
                    regular.CheckEmail();
                    break;
            }
            
        }
    }
}