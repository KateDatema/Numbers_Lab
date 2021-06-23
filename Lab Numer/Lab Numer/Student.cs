using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Numer
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        internal bool Max(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
