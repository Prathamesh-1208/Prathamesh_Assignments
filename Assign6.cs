using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpBasics
{
    abstract class arithmetic
    {
        public static void Main(string[] args)
        {

            excel obj2 = new excel();
            obj2.add(1, 2);
            obj2.multi(3, 5);
            obj2.divide(3, 5);
        }
        public void add(int num1, int num2)
        {
            System.Console.WriteLine("The addition of {0} and {1} is {2}", num1, num2, (num1 + num2));
        }
    }

    class excel : arithmetic
    {
        public void multi(int num1, int num2)
        {
            System.Console.WriteLine("The multiplication of {0} and {1} is {2}", num1, num2, (num1 * num2));
        }

        public void divide(int num1, int num2)
        {
            System.Console.WriteLine("The division of {0} and {1} is {2}", num1, num2, (num1 / num2));
        }


      
    }
        
    }

