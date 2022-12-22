using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq16
    {
        public static void Test()
        {
            //int[] numbersArray = { 10, 22, 30, 40, 50, 60 };
            ////Converting Integer Array to List using ToList method
            //List<int> numbersList = numbersArray.ToList();
            //foreach (var num in numbersList)                        // tolist
            //{
            //    Console.WriteLine(num);
            //}

            //List<int> numbersList = new List<int>()
            //{
            //    10, 22, 30, 40, 50, 60
            //};                                                      //toarray
            ////Converting List to Array
            //int[] numbersArray = numbersList.ToArray();
            //foreach (var num in numbersArray)
            //{
            //    Console.WriteLine(num);
            //}




            //ArrayList list = new ArrayList
            //{
            //    10,
            //    20,
            //    30
            //};
            //IEnumerable<int> result = list.Cast<int>();
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}


            ArrayList list = new ArrayList
            {
                10,
                20,
                30,
            };
            //The following statement throws System.InvalidCastException
            list.Add("40");
            IEnumerable<int> result = list.Cast<int>();
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
