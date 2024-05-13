using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharpBasics
{
    delegate int mydel();
    delegate int yourdel(int a);
    internal class DelegateAssign
    {
        public static void Main(string[] args)
        {
            mydel obj;
            Console.WriteLine("Which type of Greetings do you want?");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            if (choice == "greet")
                obj = new mydel(greet);
            else
                obj = new mydel(merrychristmas);
            obj();

            yourdel obj1;
            Console.WriteLine("Enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
            number = number % 2;
            if (number == 0)
            {
                obj1 = new yourdel(even);
            }
            else
            {
                obj1 = new yourdel(odd);
            }
            obj1(number);
        }
    

        static int greet() 
        {
            Console.WriteLine("Hello everyone");
            return 0;
        }

        static int merrychristmas() 
        {
            Console.WriteLine("Happy Christmas Day");
            return 0;
        }

        static int even(int a)
        {
            Console.WriteLine("This is even number");
            return a;
        }

        static int odd(int a)
        {
            Console.WriteLine("This is odd number");
            return a;
        }
    }


}
