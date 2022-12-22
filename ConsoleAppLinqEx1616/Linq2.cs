using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    public class Student1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    internal class Linq2
    {
       
        public static void Test()
        {

            List<Student1> studentList = new List<Student1>()
            {
                new Student1(){ID = 1, Name = "James", Gender = "Male"},
                new Student1(){ID = 2, Name = "Sara", Gender = "Female"},
                new Student1(){ID = 3, Name = "Steve", Gender = "Male"},
                new Student1(){ID = 4, Name = "Pam", Gender = "Female"}
            };

            //Linq Query to Fetch all students with Gender Male
            IEnumerable<Student1> QuerySyntax = from std in studentList
                                               where std.Gender == "Male"
                                               select std;
            //Iterate through the collection
            foreach (var student in QuerySyntax)
            {
                Console.WriteLine($"ID : {student.ID}  Name : {student.Name}");
            }

            Console.ReadKey();

        }
    }
}
