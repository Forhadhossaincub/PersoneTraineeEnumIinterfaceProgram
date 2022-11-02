using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OL04_M3_Class_20_Work_02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Thread.CurrentThread.Name = "Main";
            Thread t1 = new Thread(Count);
            Thread t2 = new Thread(Count);
            t1.Name = "Child1";
            t2.Name = "Child2";
            t1.Start();
            t2.Start();
            //t1.Join();
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} Count: {i}");
                Thread.Sleep(250);
            }
            
            Console.ReadLine();
        }//Main
        static void Count()
        {
            for(int i=1; i <= 50;i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} Count: {i}");
                Thread.Sleep(250);
            }
        }//Count
    }
}
