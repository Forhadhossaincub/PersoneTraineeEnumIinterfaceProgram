using OL04_M3_Class_20_Work_01.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL04_M3_Class_20_Work_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee t = new Trainee();
            Console.Write("ID: ");
            t.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            t.Name = Console.ReadLine();
            Console.Write("Address: ");
            t.Address = Console.ReadLine();
            Console.Write("Date of birth: ");
            t.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Course [1-Web, 2-Programming, 3-Database, 4-Networking: ");
            t.Course = (Course)int.Parse(Console.ReadLine());
            Console.Write("Subject: ");
            string input = Console.ReadLine();
            t.AddSubjects(input.Split(','));
            Console.WriteLine();
            Console.WriteLine("==========output===================");
            Console.WriteLine($"Id: {t.Id} Name: {t.Name} Address: {t.Address}, Birth Date :{t.DateOfBirth:dd-MM-yyyy}");
            Console.WriteLine($"Course: {t.Course}");
            Console.WriteLine($"Subjects: {t.GetSubjects()}");
            Console.ReadLine();

        }
    }
}
