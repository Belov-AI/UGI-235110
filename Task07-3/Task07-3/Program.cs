using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой пешки");
            var whitePawnPosition = Console.ReadLine();

            int whitePawnRow, whitePawnColumn;

            DecodePosition(whitePawnPosition, out whitePawnRow, out whitePawnColumn);
            Console.WriteLine($"({whitePawnRow}; {whitePawnColumn})");

            Console.ReadKey();
        }

        static void DecodePosition(string position, out int x, out int y)
        {
            x = int.Parse(position[1].ToString());
            y = (int)position[0] - 0x60;
        }
        
    }
}
