using System;
using System.Diagnostics;
using System.Text;

namespace PerformanceEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speed testing");
            Stopwatch stopwatch = Stopwatch.StartNew();

            stopwatch.Start();

            string test = "";
            for(int i = 0; i < 30000; i++)
            {
                test += "Testing";
            }
            stopwatch.Stop();
            Console.WriteLine($"Time Taken Using String Concatenation: {stopwatch.ElapsedMilliseconds}ms ");

            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            StringBuilder test1 = new StringBuilder();

            for (int i = 0; i < 30000; i++)
            {
                test1.Append("testing");
            }
            stopwatch.Stop();
            Console.WriteLine($"Time Taken Using String Builder: {stopwatch.ElapsedMilliseconds}ms");

            Console.ReadLine();
        }
        //In C#, an Action is a delegate type defined in the System namespace that represents a method containing a void return type and no parameters. It's part of the built-in delegate types that provide a simple way to pass methods as parameters without having to declare a custom delegate
        public static void CalculateSpeed(Action<int> methodToTest, int[] repetitions, string testName )
        {
            for(int i = 0; i < repetitions.Length; i++)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                stopwatch.Start();

                methodToTest(repetitions[i]);

                stopwatch.Stop();
                Console.WriteLine($"{testName} {repetitions[i]} reps:{stopwatch.ElapsedMilliseconds}ms");
            }
        }
    }
}
