using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpBasics
{
    class TryCatchAssign
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number :");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number :");
                int num2 = Convert.ToInt32(Console.ReadLine());

                double result = DivideNumbers(num1, num2);
                Console.WriteLine($"Result of dividing {num1} by {num2} is: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter valid integer numbers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static double DivideNumbers(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)num1 / num2;
        }
    }

}
