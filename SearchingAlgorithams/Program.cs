using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linearSearch = new LinearSearch();
            var binarySearch = new BinarySearch();


            var output = linearSearch.LinearSearchAlgoritham(Constants.Countries, "Niger");

            Console.WriteLine(output);

            Console.WriteLine("================++++++============================");
            int[] input = new int[] { 1, 2, 4, 7, 9, 11, 14, 15, 21, 72, 77, 81, 83};
            var index = binarySearch.BinarySearchAlgoritham(input, 2);

            Console.WriteLine($"Middle {index}");
            Console.ReadKey();
        }
    }
}
