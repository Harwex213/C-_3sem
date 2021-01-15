using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab15
{
    class Program
    {
        public static void PrintAllProcess()
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {process?.Id} | Name: {process?.ProcessName} | BasePriority: {process?.BasePriority}");
            }
        }

        public static void DomainExploration()
        {
            var domain = Thread.GetDomain();
            Console.WriteLine($"Domain name: {domain.FriendlyName}");
            Console.WriteLine($"Config datails: {domain.SetupInformation}");
            Console.WriteLine("Assemblies: ");
            foreach (var assembly in domain.GetAssemblies())
            {
                Console.WriteLine("Full name: " + assembly.FullName);
                Console.WriteLine("Locaiton: " + assembly.Location + '\n');
            }

            var d = AppDomain.CreateDomain("domain");
            d.Load(domain.GetAssemblies()[0].FullName);
            AppDomain.Unload(d);
        }

        static object locker = new object();
        public static void outputNumbers(object inputN)
        {
            lock (locker)
            {
                int n = (int)inputN;
                if (Thread.CurrentThread.Name == "1")
                    for (int i = 1; i <= n; i++)
                        if (i % 2 != 0)
                            Console.WriteLine($" {i} ");

                if (Thread.CurrentThread.Name == "2")
                    for (int i = 1; i <= n; i++)
                        if (i % 2 == 0)
                            Console.WriteLine($" {i} ");
            }
        }

        #region Mutex
        static Mutex mutex = new Mutex();
        public static void outputNumbersSinh(object inputN)
        {
            int n = (int)inputN;
            if (Thread.CurrentThread.Name == "1")
            {
                for (int i = 1; i <= n; i++)
                    if (i % 2 != 0)
                    {
                        mutex.WaitOne();
                        Console.WriteLine($" {i} ");
                        mutex.ReleaseMutex();
                    }
            }

            if (Thread.CurrentThread.Name == "2")
            {
                for (int i = 1; i <= n; i++)
                    if (i % 2 == 0)
                    {
                        mutex.WaitOne();
                        Console.WriteLine($" {i} ");
                        mutex.ReleaseMutex();
                    }
            }
        }
        #endregion
        public static void timerFunc(object a)
        {
            Console.WriteLine("\n--------\n I'm a timer! \n--------\n");
        }
        public static void someFunc()
        {
            Thread thread = Thread.CurrentThread;
            Console.Write("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Thread.Sleep(100);
                Console.Write(" " + i);

                if (i == n/2)
                {
                    thread.Suspend();
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // Task 1.
            PrintAllProcess();

            // Task 2.
            DomainExploration();

            // Task 4.
            Thread thread1 = new Thread(new ParameterizedThreadStart(outputNumbers)) { Name = "1", Priority = ThreadPriority.Highest };
            Thread thread2 = new Thread(new ParameterizedThreadStart(outputNumbers)) { Name = "2", Priority = ThreadPriority.AboveNormal };
            Console.WriteLine("\n-----------------------");
            thread1.Start(10);
            thread2.Start(10);

            //Console.WriteLine("\n-----------------------");
            //Thread thread3 = new Thread(new ParameterizedThreadStart(outputNumbersSinh)) { Name = "1" };
            //Thread thread4 = new Thread(new ParameterizedThreadStart(outputNumbersSinh)) { Name = "2" };
            //thread3.Start(10);
            //thread4.Start(10);

            thread1.Join();
            thread2.Join();
            //thread3.Join();
            //thread4.Join();

            // Task 3 & 5.
            TimerCallback tm = new TimerCallback(timerFunc);
            Timer timer = new Timer(tm, null, 0, 2000);

            Thread thread = new Thread(new ThreadStart(someFunc));
            thread.Start();

            while (true)
                if (thread.ThreadState == System.Threading.ThreadState.Suspended)
                {
                    Thread.Sleep(500);
                    thread.Resume();
                    break;
                }
        }
    }
}
