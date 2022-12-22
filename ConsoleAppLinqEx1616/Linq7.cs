using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq7
    {
        public static void Test()
        {
            List<int> data = new List<int>() { 1, 4, 2, 5, 3, 6,  10 };
            Console.WriteLine("before soorting");
            foreach (var item in data)
            {
                
                Console.WriteLine(item);
            }
            var res = from n in data
                      orderby n
                      select n;                        //order by asending
            Console.WriteLine("after soorting");
            foreach (var item in res)
            {
                
                Console.WriteLine(item);
            }
            var res2 = from n in data
                      orderby n descending                  //order by desinding
                      select n;
            Console.WriteLine("after soorting");
            foreach (var item in res2)
            {

                Console.WriteLine(item);
            }
        }
    }
}
