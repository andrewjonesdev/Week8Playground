using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Playground
{
    public class School
    {
        public List<Classroom> Classrooms { get; set; }
        public string Name { get; set; }
        public School(String Name, List<Classroom> Classrooms) 
        {
            this.Name = Name;
            this.Classrooms = Classrooms.Count>0 ? Classrooms : new List<Classroom>();
        }
    }
}
