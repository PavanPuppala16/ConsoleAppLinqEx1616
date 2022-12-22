using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{

    internal class Linq11
    {
        public static void Test()
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            var Result = IntArray.All(x => x > 10);
            Console.WriteLine("Is All Numbers are greater than 10 : " + Result);
        }
    }
}
