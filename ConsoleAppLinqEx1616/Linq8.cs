using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    public class StudenEF
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public static List<StudenEF> GetAllStudents()
        {
            List<StudenEF> listStudents = new List<StudenEF>()
            {
                new StudenEF{ID= 101,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE"},
                new StudenEF{ID= 102,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC"},
                new StudenEF{ID= 103,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC"},
                new StudenEF{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC"},
                new StudenEF{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE"},
                new StudenEF{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE"},
                new StudenEF{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE"},
                new StudenEF{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC"},
                new StudenEF{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC"},
                new StudenEF{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE"}
            };
            return listStudents;
        }

        internal class Linq8
        {
           
            public static void Test()
            {
                //Method Syntax
                var MS = StudenEF.GetAllStudents()
                                  .OrderBy(x => x.FirstName)
                                  .ThenBy(y => y.LastName)
                                  .ToList();

                foreach (var student in MS)
                {
                    Console.WriteLine("First Name :" + student.FirstName + ", Last Name : " + student.LastName);
                }
                var QS = (from std in StudenEF.GetAllStudents()
                          orderby std.FirstName, std.LastName
                          select std);
                foreach (var student in QS)
                {
                    Console.WriteLine("First Name :" + student.FirstName + ", Last Name : " + student.LastName);
                }

            }
        }
    }
}
