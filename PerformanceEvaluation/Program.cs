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
            Console.WriteLine($"Time Taken Using String Concatenation: {stopwatch.ElapsedMilliseconds} ");

            stopwatch.Restart();
            Stopwatch.StartNew();
            StringBuilder test1 = new StringBuilder();

            for (int i = 0; i < 30000; i++)
            {
                test1.Append("testing");
            }
            stopwatch.Stop();
            Console.WriteLine($"Time Taken Using String Builder: {stopwatch.ElapsedMilliseconds}");

            Console.ReadLine();

        }
    }
}
