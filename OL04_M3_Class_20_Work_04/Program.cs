using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OL04_M3_Class_20_Work_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Task
                 .Run<long>(() => AddUp(20))
                 .ContinueWith(t => Console.WriteLine($"Got result {t.Result} @{DateTime.Now}"));
            Task
                .Run<long>(() => AddUp(10))
                .ContinueWith(t => Console.WriteLine($"Got result {t.Result} @{DateTime.Now}"));
            Task
                .Run<long>(() => AddUp(5))
                .ContinueWith(t => Console.WriteLine($"Got result {t.Result} @{DateTime.Now}"));
            Task
                 .Run<long>(() => AddUp(12))
                 .ContinueWith(t => Console.WriteLine($"Got result {t.Result} @{DateTime.Now}"));

            for (int i=0; i<20; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Working..");
                Thread.Sleep(350);
            }
            
            Console.ReadLine();
        }
        static long AddUp(int n)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started proceessing...@{DateTime.Now}");//
            long sum = 0;
            for(int i=1; i <= n; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} adds {i}");//
                sum += i;
                Thread.Sleep(250);
            }
            return sum;
        }
    }
}
