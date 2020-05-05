using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CodingChallengeWeek3
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true) { 
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Is the Number Even?");
                Console.WriteLine("2) Multiplication Table");
                Console.WriteLine("3) Alternating Elements");
                Console.WriteLine("4) Exit");
                Console.Write("\r\nSelect an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        IsItEven();
                        continue;
                    case "2":
                        MultTable();
                        continue;
                    case "3":
                        Shuffle();
                        continue;
                    case "4":
                        break;
                    default:
                        continue;
                }
                break;
            }
            static void IsItEven()
            {
                Console.Clear();
                Console.WriteLine("Input your number:");
                string numberTest = Console.ReadLine();
                int validNum;
                static bool IsEven(int value)
                {
                    return value % 2 == 0;
                }
                if (Int32.TryParse(numberTest, out validNum) == true)
                {
                    validNum = Int32.Parse(numberTest);
                    if(IsEven(validNum) == true)
                    {
                        Console.WriteLine($"{validNum} is an even number.");
              
                    }
                    else
                    {
                        Console.WriteLine($"{validNum} is an odd number.");
            
                    }
                }
                else
                {
                    Console.WriteLine("This is not a number.");
                }
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadLine();
            }
            static void MultTable()
            {
                Console.Clear();
                Console.WriteLine("Input your number:");
                string multiplyTable = Console.ReadLine();
                int multNum;
                if (Int32.TryParse(multiplyTable, out multNum) == true)
                {
                    int i = 1;
                    multNum = Int32.Parse(multiplyTable);
                    while (i < 10)
                    {
                        
                        int multiResult = i * multNum;
                        Console.WriteLine($"{multNum} * {i} = {multiResult}");
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("This is not a number.");
                }
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadLine();
            }
            static void Shuffle()
            {
                Console.Clear();
                string[] inputFirst = new string[5];
                string[] inputSecond = new string[5];
                int f = 0;
                int s = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Input first list item {i+1}:");
                    inputFirst[f] = Console.ReadLine();
                    f++;
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Input second list item {i+1}:");
                    inputSecond[s] = Console.ReadLine();
                    s++;
                }
                int x = 0;
                for (int i = 0; i < 5; i++) {
                    Console.Write($"{inputFirst[x]} {inputSecond[x]} ");
                    x++;
                }
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadLine();
            }
    }


    }
}
