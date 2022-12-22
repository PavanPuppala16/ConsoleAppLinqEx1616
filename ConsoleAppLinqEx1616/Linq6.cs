using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq6
    {
        public static void Test()
        {
            List<int> data = new List<int>()
            {
                1,2,3,4,5,6
            };
            List<int> data1 = new List<int>() { 10, 20 };
            //method syntax:
            var MS = data.Concat(data1);
            // query syntax
            var QS = (from n in data
                      select n).Concat(data1);
            foreach(var item in QS)
            {
                Console.WriteLine(item);
            }
        }
    }
}
