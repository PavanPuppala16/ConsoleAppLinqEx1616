using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq5
    {
        public static void Test()
        {
            List<int> data = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> data2 = new List<int>() { 2, 3, 4, 6, 7 };
            //METHOD SYNTAX
            var res = data.Union(data2);
            //QUERYSYNATX
            var res1 = (from r in data
                        select r).Union(data2);
            foreach(var item  in res1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
