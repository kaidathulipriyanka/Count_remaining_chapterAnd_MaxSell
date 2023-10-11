using System;
using System.Collections.Generic;
namespace CountRemainingChapters
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the number of chapters (N): ");
            int N = int.Parse(Console.ReadLine());

            List<Tuple<int, int>> chapters = new List<Tuple<int, int>>();

            Console.WriteLine("Enter the start and end pages of each chapter:");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Chapter {i + 1} - Start Page: ");
                int startPage = int.Parse(Console.ReadLine());

                Console.Write($"Chapter {i + 1} - End Page: ");
                int endPage = int.Parse(Console.ReadLine());

                chapters.Add(Tuple.Create(startPage, endPage));
            }

            Console.Write("Enter the current reading page (K): ");
            int K = int.Parse(Console.ReadLine());

            int remainingChapters = CalculateRemainingChapters(chapters, K);

            Console.WriteLine("Number of chapters yet to read: " + remainingChapters);
        }

        static int CalculateRemainingChapters(List<Tuple<int, int>> chapters, int K)
        {
            int remainingChapters = 0;

            foreach (var chapter in chapters)
            {
                int startPage = chapter.Item1;
                int endPage = chapter.Item2;

                 if (startPage <= K && K <= endPage)
                {
                     remainingChapters = chapters.Count - chapters.IndexOf(chapter);
                    break;
                }
            }

            return remainingChapters;
        }
    }
}