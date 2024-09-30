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
            double angleInDegrees = 15;
            double angleInRadians = angleInDegrees * Math.PI / 180;
            var sin = Math.Sin(angleInRadians);
            var cos = Math.Cos(angleInRadians);
            Console.WriteLine("sin(15\xB0) = " + Math.Round(sin,3));
            Console.WriteLine("cos(15\xB0) = " + Math.Round(cos, 3));

            angleInDegrees = 37;
            angleInRadians = angleInDegrees * Math.PI / 180;
            sin = Math.Sin(angleInRadians);
            cos = Math.Cos(angleInRadians);
            Console.WriteLine("sin(37\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(37\xB0) = " + Math.Round(cos, 3));

            angleInDegrees = 113;
            angleInRadians = angleInDegrees * Math.PI / 180;
            sin = Math.Sin(angleInRadians);
            cos = Math.Cos(angleInRadians);
            Console.WriteLine("sin(113\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(113\xB0) = " + Math.Round(cos, 3));

            Console.WriteLine();
            Console.WriteLine("Введите угол в градусах");
            angleInDegrees = double.Parse(Console.ReadLine());
            angleInRadians = angleInDegrees * Math.PI / 180;
            sin = Math.Sin(angleInRadians);
            cos = Math.Cos(angleInRadians);
            Console.WriteLine("sin(" + angleInDegrees + "\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(" + angleInDegrees + "\xB0) = " + Math.Round(cos, 3));

            Console.ReadKey();
        }
    }
}
