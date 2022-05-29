using System;


namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counts = int.Parse(Console.ReadLine());
           decimal sum = 0M;
            for (int i = 1; i <=counts; i++)
            {
                decimal currentValue = decimal.Parse(Console.ReadLine());
                sum += currentValue;
            }
            Console.WriteLine(sum);
        }
    }
}
