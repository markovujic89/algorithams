using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bubbleSort = new BubbleSort();

            var sortedArray = bubbleSort.BubbleSortArray(new int[] { 5, 7, 11, 10, 2, 15, 8 });

            foreach ( var item in sortedArray )
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
