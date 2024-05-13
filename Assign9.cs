using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpBasics
{
    class Program1
    {
        static void Main(string[] args)
        {
            add(12, 45);
            System.Console.WriteLine("****************");
            add(35, 23, 12);
            System.Console.WriteLine("****************");
            pricelist("Parle", "Hide and Seek", "Cream Biscuits", "Glucose");
        }

        static void add(params int[] a)
        {
            foreach (int i in a)
            {
                System.Console.WriteLine(i);
            }
        }
        static void pricelist(string companyname, params string[] products)
        {
            System.Console.WriteLine("{0} has the following products", companyname);

            for (int i = 0; i < products.Length; i++)
            {
                System.Console.WriteLine(products[i]);
            }
        }
    }
}
