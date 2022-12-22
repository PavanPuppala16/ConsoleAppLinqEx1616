using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq3
    {
        public static void Test()
        {
            List<int> intCollection = new List<int>()
            {
                1,2,3,2,3,4,4,5,6,3,4,5
            };
            //Using Method Syntax
            var MS = intCollection.Distinct();
            //Using Query Syntax
            var QS = (from num in intCollection
                      select num).Distinct();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }



        }
    }
}
