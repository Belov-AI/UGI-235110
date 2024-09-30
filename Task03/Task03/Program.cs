using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двузначное число");
            var number = int.Parse(Console.ReadLine());

            var unints = number % 10;
            var tens = number / 10;
            var result = number * 100 + unints * 10 + tens;

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
