using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = F(3, 2) + F(7, 5) + F(2, 7) + F(5, 11);

            Console.WriteLine($"x = {x:F3}");

            Console.ReadKey();
        }

        static double F(double a, double b)
        {
            return Math.Sqrt((a + b + Math.Sqrt(a)) / b);
        }
    }
}
