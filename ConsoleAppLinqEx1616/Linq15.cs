using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq15
    {
        public static void Test()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            //var groupedResult = from s in studentList
            //                    group s by s.Age;

            ////iterate each group        
            //foreach (var ageGroup in groupedResult)
            //{
            //    Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

            //    foreach (Student s in ageGroup) // Each group has inner collection
            //        Console.WriteLine("Student Name: {0}", s.StudentName);

            var res = (from n in studentList
                       select n).GroupBy(n => n.Age);
            foreach (var ageGroup in res)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }

        }
    }
}
