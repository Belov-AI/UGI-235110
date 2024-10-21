using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Улитка");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Тихо-тихо ползи");
            Console.WriteLine("Улитка по склону Фудзи");
            Console.WriteLine("Вверх до самых высот");

            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
