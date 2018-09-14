using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace AsyncProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Starting tasks - Action, Lambda, Anon

            //Task task = new Task(new Action(SayHi));
            //task.Start();
            //Task t2 = new Task(delegate()
            //{
            //    Console.WriteLine("Task 2 is starting");
            //Console.WriteLine("Task 2 is Running");
            //Console.WriteLine("Hi there from Task 2");
            //Thread.Sleep(15000);
            //Console.WriteLine("Task 2 is complete");
            //});
            //t2.Start();

            //Task t3 = new Task(() =>
            //{

            //    Console.WriteLine("Task 3 is starting");
            //Console.WriteLine("Task 3 is Running");
            //Console.WriteLine("Hi there from Task 3");
            //Thread.Sleep(15000);
            //Console.WriteLine("Task 3 is complete");

            //Console.WriteLine("What is your name!");
            //});
            //t3.Start();

            //var name = Console.ReadLine();
            //Console.WriteLine("Welcome back : " + name);
            #endregion

            #region Task with Params
            //var noName = "None";
            //Task task1 = new Task(new Action<object>(SayHi), "Jennifer");
            //task1.Start();

            //Task task2 = new Task(delegate(object name){
            //    Console.WriteLine("Welcome back " + name);
            //}, "marc");
            //task2.Start();

            //Task task3 = new Task(n => { Console.WriteLine("Welcome back " + n); }, noName);
            //task3.Start();

            #endregion

            #region Return values with Tasks
            //Task<int> task1 = new Task<int>(() =>
            //{
            //    int result = 0;
            //    for (int i = 0; i < 5; i++)
            //    {
            //        result += i;
            //        Console.WriteLine(i);
            //    }
            //    return result;
            //}
            //);
            //task1.Start();
            //Console.WriteLine("Result = " + task1.Result);

            #endregion

            #region Checking status on Task

            //CancellationTokenSource cancelToken = new CancellationTokenSource();
            //CancellationToken token = cancelToken.Token;

            //Task t1 = new Task(() =>
            //{
            //    for (int i = 1; i < 500000000; i++)
            //    {
            //        Console.WriteLine(i);
            //        if (i % 6000 == 0)
            //        {
            //            cancelToken.Cancel();
            //        }
            //        if (token.IsCancellationRequested)
            //        {
            //            Console.WriteLine("Task cancelled!");
            //            return;
            //        }
            //    }
            //});
            //t1.Start();

            //bool isRunning = true;

            //while (isRunning)
            //{
            //    if (t1.Status == TaskStatus.Running)
            //    {
            //        Console.WriteLine(t1.Status);
            //    }
            //    else if (t1.Status == TaskStatus.RanToCompletion || t1.Status == TaskStatus.Canceled)
            //    {
            //        Console.WriteLine("It's done stop monitoring");
            //        isRunning = false;
            //        Console.WriteLine(t1.Status);
            //    }
            //    Thread.Sleep(1000);

            //}

            #endregion

            #region Waiting on tasks

            //Task t1 = new Task(() =>
            //{
            //    Console.WriteLine("Task 1 is Started");
            //    Console.WriteLine("Task 1 is running... \n");
            //    Thread.Sleep(8000);
            //    Console.WriteLine("Task 1 is Finished!");

            //});
            //t1.Start();

            //Task t2 = new Task(() =>
            //{
            //    Console.WriteLine("Task 2 is Started");
            //    t1.Wait();
            //    Console.WriteLine("Task 2 is running... \n");

            //    Thread.Sleep(6000);     
            //    Console.WriteLine("Task 2 is Finished!");

            //});
            //t2.Start();

            //Task t3 = new Task(() =>
            //{
            //    Console.WriteLine("Task 3 is Started");
            //    t1.Wait();
            //    Console.WriteLine("Task 3 is running... \n");
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Task 3 is Finished!");

            //});
            //t3.Start();

            //Console.WriteLine("Main thread done");


            #endregion

            #region Task.Run method
            //Task.Run(() => { Console.WriteLine("Hey from task"); });

            //SayHiFromTask();

            //AddNumbersTask(2, 8, 99, 2);
            #endregion

            #region Async and await
            Console.WriteLine("First we are inside the main method...");
            //RunProcess(1, 100000);
            //RunProcess(2, 100000);
            RunAsyncProcess(1, 100000);
            RunAsyncProcess(2, 100000);

            #endregion

            Console.ReadKey();
        }

        private static async Task RunAsyncProcess(int processNumber, int processLoops)
        {
            Console.WriteLine("\nControl is with process " + processNumber);
            Console.WriteLine($"Process ({processNumber}) has started.");
            Console.WriteLine($"Process ({processNumber}) is running....");
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Running await process");
                for (int i = 0; i < processLoops; i++)
                {

                }
                Console.WriteLine("await process done!");
            });
            Console.WriteLine($"process ({processNumber}) has finished!");
            Console.WriteLine("\nControle is back to main method...");
        }

        private static void RunProcess(int processNumber, int processLoops)
        {
            Console.WriteLine("\nControl is with process " + processNumber);
            Console.WriteLine($"Process ({processNumber}) has started.");
            Console.WriteLine($"Process ({processNumber}) is running....");
            for (int i = 0; i < processLoops; i++)
            {

            }
            Console.WriteLine($"process ({processNumber}) has finished!");
            Console.WriteLine("\nControle is back to main method...");
        }

        private static Task SayHiFromTask()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("hey from task method");
            }
            );
        }

        private static Task<int> AddNumbersTask(params int[] numbers)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Task add numbers started!");
                int result = 0;
                foreach (var num in numbers)
                {
                    result += num;
                }
                Console.WriteLine("The result is: " + result);
                return result;
            }
            );
        }

        public static void SayHi()
        {
            Console.WriteLine("Task is starting");
            Console.WriteLine("Task is Running");
            Console.WriteLine("Hi there");
            Thread.Sleep(15000);
            Console.WriteLine("Task is complete");
        }
        public static void SayHi(object name)
        {
            Console.WriteLine("Task is starting");
            Console.WriteLine("Task is Running");
            Console.WriteLine("Hi there " + name);
            Thread.Sleep(15000);
            Console.WriteLine("Task is complete");
        }
    }
}
