using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertationSort
    {
        public int[] InsertationSorting(int[] array) 
        {
            for(int i =1; i <array.Length; i++)
            {
                var currentValue = array[i];
                int j = i - 1;

                for (j = i -1; j>=0 && array[j] > currentValue; j--)
                {
                    array[j+1] = array[j];
                }

                array[j+1] = currentValue;
            }

            return array;
        }
    }
}
