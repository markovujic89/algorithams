using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var insertationSort = new InsertationSort();

            var output = insertationSort.InsertationSorting(new int[] { 11, 21, 3, 7, 55, 2, 6, 14 });

            foreach ( var item in output )
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
