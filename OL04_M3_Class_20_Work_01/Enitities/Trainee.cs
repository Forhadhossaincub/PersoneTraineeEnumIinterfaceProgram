using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL04_M3_Class_20_Work_01.Enitities
{
    public sealed class Trainee : Person, ISubjects
    {
        public Trainee() { this.Subjects = new List<string>(); }
        public Trainee(int id, string name, string address, DateTime dob, Course course):base(name, address, dob)
        {
            this.Id = id; this.Course = course;
            this.Subjects = new List<string>();
        }
        public int Id { get; set; }
        public Course Course { get; set; }
        private List<string> Subjects { get; set; }

        

        public override int Age()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
        public void AddSubjects(string[] subjects)
        {
            this.Subjects.AddRange(subjects);
        }
        public string GetSubjects()
        {
            return string.Join(",", Subjects.ToArray());
        }
    }
}
