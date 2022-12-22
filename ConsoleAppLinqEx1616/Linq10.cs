using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq10
    {
        public static void Test()
        {
            int[] intNumbers = new int[] { 10, 80, 50, 90, 60, 30, 70, 40, 20, 100 };
            //Using Method Syntax
            int MSLergestNumber = intNumbers.Max();
            //Using Query Syntax
            int QSLergestNumber = (from num in intNumbers
                                   select num).Max();
            Console.WriteLine("Largest Number = " + MSLergestNumber);
        }
    }
}
