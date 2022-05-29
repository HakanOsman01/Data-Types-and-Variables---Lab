using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int i = 1; i <=number; i++)
            {
                int numberToProcess = i;
                int sum = 0;
                while (numberToProcess > 0)
                {
                    int curentDigith = numberToProcess % 10;
                    numberToProcess = curentDigith / 10;
                    sum += curentDigith;
                }
                bool isSpecial = (sum==5 || sum == 7 || sum== 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
