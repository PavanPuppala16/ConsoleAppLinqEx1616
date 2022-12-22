using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq4
    {
        public static void Test()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            //Method Syntax
            var MS = dataSource1.Except(dataSource2).ToList();
            //Query Syntax
            var QS = (from num in dataSource1
                      select num)
                      .Except(dataSource2).ToList();
            foreach (var item in QS)
            {
                Console.WriteLine(item);
            }

        }
    }
}
