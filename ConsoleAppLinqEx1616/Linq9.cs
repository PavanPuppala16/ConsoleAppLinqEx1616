using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq9
    {
        public static void Test()
        {

            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };
            //Using Method Syntax
            int MSTotal = intNumbers.Sum();
            //Using Query Syntax
            int QSTotal = (from num in intNumbers
                           select num).Sum();
            Console.WriteLine("Sum = " + QSTotal);

        }
    }
}
