using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Playground
{
    public class Student
    {
        public List<int> Grades { get; set; }
        public string Name { get; set; }
        public Student(String Name, List<int> Grades)
        {
            this.Name = Name;
            this.Grades = Grades.Count > 0 ? Grades : new List<int>();
        }
    }
}
