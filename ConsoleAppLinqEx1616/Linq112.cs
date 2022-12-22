using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    public class pavan
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }
    internal class Linq112
    {
        public static void Test()
        {
            IList<pavan> studentList = new List<pavan>() {
        new pavan() { id = 1, name = "John", surname = "puppala"} ,
        new pavan() { id = 2, name = "Moin",  surname = "puppala" } ,
        new pavan() { id = 3, name = "Bill",  surname = "macha" } ,
        new pavan() { id = 4, name = "Ram" , surname = "macha"} ,
        new pavan() { id = 5, name = "Ron" , surname = "macha" }
    };

            var res = studentList.SelectMany(n => n.surname);
            foreach(var item in res)
            {
                Console.WriteLine(item);
            }

        }
        

    }
}
