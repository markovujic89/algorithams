using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzingPerformanceOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 3, 4, 5, 6 };

            List<int> numbers = new List<int> { 11, 12, 13, 14, 15, 16, 17 };

            Console.WriteLine("Numbers, initial order!!");

            numbers.ForEach(x =>
            {
                Console.WriteLine(x);
            });

            numbers.Insert(0,10);

            Console.WriteLine("Numbers, after insertation new elements on index 0");

            numbers.ForEach(x =>
            {
                Console.WriteLine(x);
            });

            int k = 20;
            decimal dec = 450.222m;

            Console.ReadLine();

        }
    }
}
