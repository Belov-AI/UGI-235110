using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinusCosinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSinusCosinus(15);
            PrintSinusCosinus(37);
            PrintSinusCosinus(113);

            Console.WriteLine();

            double angleInDegrees;
            Console.WriteLine("Введите угол в градусах");
            angleInDegrees = double.Parse(Console.ReadLine());
            PrintSinusCosinus(angleInDegrees);

            Console.ReadKey();
        }

        private static void PrintSinusCosinus(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180;
            var sin = Math.Sin(angleInRadians);
            var cos = Math.Cos(angleInRadians);
            Console.WriteLine("sin(" + angleInDegrees + "\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(" + angleInDegrees + "\xB0) = " + Math.Round(cos, 3));
        }
    }
}
