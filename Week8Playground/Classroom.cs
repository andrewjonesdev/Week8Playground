using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Playground
{
    public class Classroom
    {
        public List<Student> Students { get; set; }
        public string Name { get; set; }
        public Classroom(String Name, List<Student> Students)
        {
            this.Name = Name;
            this.Students = Students.Count > 0 ? Students : new List<Student>();
        }
    }
}
