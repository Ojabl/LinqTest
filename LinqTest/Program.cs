using System;

namespace LinqTest
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for(int i=1; i<=99; i++)
            {
                numbers.Add(i);
            }
            IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(5));
            foreach(int i in firstAndLastFive)
            {
                Console.WriteLine(i);  
            }

            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            IEnumerable<int> result =
                from v in values
                where v < 37
                orderby -v
                select v;

            foreach (int i in result)
                Console.Write($"{i} ");
        }

    }
}