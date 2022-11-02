using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL04_M3_Class_20_Work_01.Enitities
{
    public abstract class Person
    {
        public Person() { }
        public Person(string name, string address, DateTime dob) {
            this.Name = name;
            this.Address = address;
            this.DateOfBirth = dob;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public abstract int Age();
    }
}
