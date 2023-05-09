using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithams
{
    /// <summary>
    /// Eliminate on bigining half of the source. 
    /// Binary search only works with sorted data source.
    /// </summary>
    public class BinarySearch
    {
        public int BinarySearchAlgoritham(int[] source, int input)
        {
            var start = 0;
            var end = source.Length - 1;
            var middle = Math.Floor((decimal)(start + end) / 2);

            while (source[(int)middle] != input && start <= end)
            {
                Console.WriteLine($"{start} {middle} {end}");

                if (input < source[(int)middle])
                {
                    end = (int)middle - 1;
                }
                else
                {
                    start = (int)middle + 1;
                }

                middle = Math.Floor((decimal)(start + end) / 2);
            }

            if (source[(int)middle]!=input)
            {
                return -1;
            }
           
            return (int)middle;
        }
    }
}
