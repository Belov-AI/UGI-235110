﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слагаемое");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе слагаемое");
            int y = int.Parse(Console.ReadLine());

            //Console.WriteLine("Cумма чисел равна " + (x + y));
            Console.WriteLine($"{x} + {y} = {x + y}");

            Console.ReadKey();
        }
    }
}
