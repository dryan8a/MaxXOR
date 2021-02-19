using System;
using System.Diagnostics;

namespace MaxXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            Random gen = new Random();
            int testsToRun = 5;
            int numberOfElements = 100000;
            double naiveTimeSum = 0;
            double efficientTimeSum = 0;


            for(int test = 0;test < testsToRun; test++)
            {
                int[] nums = new int[numberOfElements];

                for(int i = 0;i<numberOfElements;i++)
                {
                    nums[i] = gen.Next(0,int.MaxValue);
                }

                timer.Restart();
                _ = MaxXORFuncs.GetNaive(nums);
                timer.Stop();
                naiveTimeSum += timer.Elapsed.TotalMilliseconds;
                Console.WriteLine($"Naive Implementation Test {test + 1}: {timer.Elapsed.TotalMilliseconds} ms");

                timer.Restart();
                _ = MaxXORFuncs.GetEfficient(nums);
                timer.Stop();
                efficientTimeSum += timer.Elapsed.TotalMilliseconds;
                Console.WriteLine($"Efficient Implementation Test {test + 1}: {timer.Elapsed.TotalMilliseconds} ms\n");
            }

            Console.WriteLine($"\nNaive Implementation Average of {testsToRun} tests: {naiveTimeSum / testsToRun} ms");
            Console.WriteLine($"Efficient Implementation Average of {testsToRun} tests: {efficientTimeSum / testsToRun} ms\n");
            Console.WriteLine($"The Efficient Implementation was {naiveTimeSum / efficientTimeSum} ms faster than the naive implementation on average.");

        }
    }
}
