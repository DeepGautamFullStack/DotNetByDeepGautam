using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LongRunningMethodTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //First uncomment below section and comment other see output using normal executions
            #region Start of normal execution of long running operations

            //var watch1 = new Stopwatch();
            //watch1.Start();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i + "-First operation print");
            //}
            //Thread.Sleep(2000);
            //watch1.Stop();
            //var result1 = watch1.Elapsed;
            //Console.WriteLine("Time taken by first operation is-" + result1);
            //var watch2 = new Stopwatch();
            //watch2.Start();
            //for (int j = 0; j < 5; j++)
            //{
            //    Console.WriteLine(j + "-Second operation print");
            //}
            //Thread.Sleep(2000);
            //watch2.Stop();
            //var result2 = watch2.Elapsed;
            //Console.WriteLine("Time taken by second operation is-" + result2);
            #endregion End of normal execution of long running operations

            //Second uncomment below section and comment other see output using thread
            #region Start of thread execution of long running operations

            Thread thread1 = new Thread(() => LongRunningClass.LongRunningMethod(5));
            thread1.Start();

            Thread thread2 = new Thread(() => LongRunningClass.LongRunningMethod(7));
            thread2.Start();

            #endregion End of thread execution of long running operations


            Console.ReadLine();
        }
    }
    public static class LongRunningClass
        {
        public static void LongRunningMethod(int iterations)
        {
            var watch3 = new Stopwatch();
            watch3.Start();
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine(i + "-First operation print");   
            }
            Thread.Sleep(2000);
            watch3.Stop();
            var result3 = watch3.Elapsed;
            Console.WriteLine("Time taken by one operation using multiple thread is-" + result3+"and last time is comibined time");

        }

        }
}

