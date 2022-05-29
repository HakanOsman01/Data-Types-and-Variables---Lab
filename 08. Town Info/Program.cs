using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameTown = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            long area = long.Parse(Console.ReadLine());
            Console.WriteLine($"Town {nameTown} has population of {population} and area {area} " +
                $"square km.");
        }
    }
}
