using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSort
    {
        public int[] BubbleSortArray(int[] array)
        {
            bool noSwaps = false;

            for(int i= array.Length; i>0; i--)
            {
                noSwaps = true;
                for(int j=0; j< i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        noSwaps = false;
                    }
                }

                if(noSwaps)
                {
                    break;
                }
            }
            return array;
        }
    }
}

// [ 5, 7, 11, 10, 2, 15, 8]
