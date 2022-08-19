using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LinqEg
{
    internal class linq
    {
        static void main()
        {
            //Comment By Deepak
            List<int> numbers = new List<int>();
            numbers.Add(20);
            numbers.Add(10);
            numbers.Add(100);
            numbers.Add(50);

            //Query syntax with Linq
            var resnumbers = from i in numbers
                             where i > 20
                             select i;
            foreach(var item in resnumbers)
            {
                Console.WriteLine(item);
            }

            //Method Syntax with Linq
            var resnumbers2 = numbers.Where(i => i > 20).Select(i => i);
            foreach (var item in resnumbers2)
            {
                Console.WriteLine(item);
            }
        }
        

    }
}
