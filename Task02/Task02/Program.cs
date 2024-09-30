using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину большого основания трапеции");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину малого основания трапеции");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите угол при основании (в градусах)");
            var alpha = double.Parse(Console.ReadLine()) * Math.PI / 180;

            var x = (a - b) / 2;
            var h = x * Math.Tan(alpha);
            var s = (a + b) * h / 2;
            Console.WriteLine("Площадь трапеции: " + s);

            var y = x / Math.Cos(alpha);
            var p = 2 * y + a + b;
            Console.WriteLine("Периметр трапеции: " + p);

            Console.ReadKey();
        }
    }
}
