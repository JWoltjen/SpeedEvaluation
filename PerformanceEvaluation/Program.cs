using System;
using System.Diagnostics;
using System.Text;

namespace PerformanceEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    Console.WriteLine("Speed testing");
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
                Console.WriteLine($"Time Taken Using String Builder: {stopwatch.ElapsedMilliseconds}ms");*/

            int[] iterations = new int[] { 500, 5000, 50000 };

            CalculateSpeed(AppendText, iterations, "Concatenate Text");
            CalculateSpeed(StringBuildTest, iterations, "StringBuilder Text");

            Console.ReadLine();
        }

        public static void AppendText(int repetitions)
        {
            string test = "";
            for (int i = 0; i < repetitions; i++)
            {
                test += "testing";
            }
        }
        public static void StringBuildTest(int repetitions)
        {
            StringBuilder test1 = new StringBuilder();

            for (int i = 0; i < repetitions; i++)
            {
                test1.Append("testing");
            }
            string sbOutput = test1.ToString();
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
