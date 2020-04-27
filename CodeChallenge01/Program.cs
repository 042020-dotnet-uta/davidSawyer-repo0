using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, sweetCount = 0, saltyCount = 0, snsCount = 0;
            while (i < 100)
            {
                i++;
                if (i % 15 == 0)
                {
                    Console.Write("sweet’nSalty ");
                    snsCount++;
                }
                else if (i % 5 == 0)
                {
                    Console.Write("sweet ");
                    sweetCount++;
                }
                else if (i % 3 == 0)
                {
                    Console.Write("salty ");
                    saltyCount++;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine($"The total number of sweets is {sweetCount}, the total number of salty's is {saltyCount} and the total number of sweet'nSalty's is {snsCount}.");
        }
    }
}