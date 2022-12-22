using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinqEx1616
{
    internal class Linq17
    {
        public static void Test()
        {
            ArrayList obj = new ArrayList();
            //assign the values to the object 'obj'   
            obj.Add("pavan");

            obj.Add("happy");

            obj.Add("UK");

            obj.Add("India");
            //Here we are converting the ArrayList object to String type of object and store the result in 'result'  

            IEnumerable<int> result = obj.Cast<int>();
            //Now with the help of foreach loop we will print the value of result  
            foreach (var item in result)

            {

                Console.WriteLine(item);

            }

            Console.ReadLine();

        }

    }
} 