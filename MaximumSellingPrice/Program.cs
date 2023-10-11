using System;
using System.Collections.Generic;
using System.Linq;
namespace MaximumSellingPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string[] firstLine = Console.ReadLine().Split();
                int n = int.Parse(firstLine[0]);
                int k = int.Parse(firstLine[1]);

                List<int> basketA = Console.ReadLine().Split().Select(int.Parse).ToList();
                List<int> basketB = Console.ReadLine().Split().Select(int.Parse).ToList();

                List<int> sortedBasketB = new List<int>(basketB);
                sortedBasketB.Sort();

                for (int i = 0; i < n; i++)
                {
                    if (k > 0 && basketA[i] < sortedBasketB[n - 1 - i])
                    {
                        basketA[i] = sortedBasketB[n - 1 - i];
                        k--;
                    }
                }

                int maxPrice = basketA.Sum();
                Console.WriteLine(maxPrice);
            }
        }

    }
}