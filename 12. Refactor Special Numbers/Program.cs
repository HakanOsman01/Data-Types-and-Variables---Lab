using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfNumber; i++)
            {
                int processNumber=i;
                int sum = 0;
                while (processNumber > 0)
                {
                    int currentNum = processNumber % 10;
                    processNumber /= 10;
                    sum+=currentNum;
                }
                bool isSpecial = (sum == 5) || (sum == 7) || (sum== 11);
                Console.WriteLine($"{i} -> {isSpecial}");
                
            }

        }
    }
}
