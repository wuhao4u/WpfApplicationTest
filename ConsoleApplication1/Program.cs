using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = args[0];
            //int x = args[1].Length;

            //            () => s.Length > x;

            //            Console.WriteLine(i => i > 5);
            Task task3 = new Task(() => MyMethod());

            Task task2 = new Task(() => { Console.WriteLine("Test"); });

            task3.Start();
            task2.Start();

            // Retrieving a Value from a Task
            // Create and queue a task that returns the day of the week as a string.
            Task<string> task1 = Task.Run<string>(() => DateTime.Now.DayOfWeek.ToString());
            // Retrieve and display the task result.
            Console.WriteLine(task1.Result);

            const int capacity = 500000;
            // Using a Parallel.For Loop
            int from = 0;
            int to = 256;
            double[] array = new double[capacity];

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            // This is the equivalent parallel implementation:
            Parallel.For(from, to, index =>
            {
                array[index] = Math.Sqrt(index);
                //Console.WriteLine(array[index].ToString());
            });
            stopWatch.Stop();
            Console.WriteLine("parallel loop runtime: {0}", stopWatch.Elapsed.ToString());

            stopWatch.Restart();
            // This is a sequential implementation:
            for (int index = 0; index < 256; index++)
            {
                array[index] = Math.Sqrt(index);
                //Console.WriteLine(array[index].ToString());
            }
            stopWatch.Stop();
            Console.WriteLine("sequential loop runtime: {0}", stopWatch.Elapsed.ToString());

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Creating Nested Tasks
            var outer = Task.Run(() =>
            {
                Console.WriteLine("Outer task starting…");
                var inner = Task.Run(() =>
                {
                    Console.WriteLine("Nested task starting…");
                    Thread.SpinWait(500000);
                    Console.WriteLine("Nested task completing…");
                });
            });
            outer.Wait();
            Console.WriteLine("Outer task completed.");

            Console.Read();
        }

        private static void MyMethod()
        {
            int i = 5;
            Console.WriteLine(i);
        }
    }
}
