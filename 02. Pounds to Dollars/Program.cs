﻿using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double britishPounds = double.Parse(Console.ReadLine());
            decimal covnertToUsa = (decimal)(britishPounds * 1.31);
            Console.WriteLine($"{covnertToUsa:f3}");
        }
    }
}
