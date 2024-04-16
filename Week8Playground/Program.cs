using System.Security.Claims;

namespace Week8Playground
{
    public class Program
    {
        static void Main(string[] args)
        {

            School claimAcademy = new School("Claim Academy", new List<Classroom>());
            Classroom partTimeCSharp = new Classroom("Part Time C#", new List<Student>());
            Student caleb = new Student("Caleb Lewis", new List<int>());
            caleb.Grades.Add(100);
            partTimeCSharp.Students.Add(caleb);
            claimAcademy.Classrooms.Add(partTimeCSharp);
            Console.WriteLine(claimAcademy.Classrooms[0].Students[0].Grades[0]);
        }

    }
}
