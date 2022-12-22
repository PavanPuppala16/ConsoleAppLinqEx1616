using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq14
    {
        public static void Test()
        {
            List<int> data = new List<int>() { 1, 2, 3, 4 };
            //   var res = data.ElementAt(1);
            //    Console.WriteLine(res);                // elementat


            //    var res2 = data.ElementAtOrDefault(10);
            //    Console.WriteLine(res2);                     //Elemetator defacult


            //var res = (from n in data
            //           select n).ElementAt(1);
            //Console.WriteLine(res);


            //var res = data.FirstOrDefault();
            //Console.WriteLine(res);                           // firstordefacult

            //var res = data.LastOrDefault();
            //Console.WriteLine(res);

            // query syntax for last or defacult
            //var res=(from n in data
            //         select n).LastOrDefault();            //last or defacult


            //var res = data.SingleOrDefault(n=>n>2000);
            //Console.WriteLine(res);

            var res = data.DefaultIfEmpty();
            foreach(var item in data)
            {                                                 //defacult or empty
                Console.WriteLine(item);
            }
           



        }
    }
}
