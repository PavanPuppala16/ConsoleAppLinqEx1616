using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    internal class Linq1
    {
        public static void Test()
        {
            IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };

            var res = from s in studentList
                      where s.Age > 12 && s.Age < 20
                      select s;


            foreach (var item in res)
            {
                Console.WriteLine(item.StudentID + " " + item.StudentName + " " + item.Age);
            }

            

        }
    }
}
