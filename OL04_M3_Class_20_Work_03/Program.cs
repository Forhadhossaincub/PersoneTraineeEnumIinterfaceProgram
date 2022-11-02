using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OL04_M3_Class_20_Work_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Task t = new Task(() => Count());
            t.Start();
            for (int i = 1; i <= 50; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Count: {i}");
                Thread.Sleep(250);
            }
            Console.ReadLine();
        }//Main
        static void Count()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Count: {i}");
                
                Thread.Sleep(250);
            }
        }//Count
        
    }//Program
}
