using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class SelectionSort
    {
        public int[] SelectionSorting(int[] array)
        {
            for(int i =0; i<array.Length; i++)
            {
                int lowest = i;

                for(int j= i+1; j<array.Length;j++)
                {
                    if (array[j] < array[lowest])
                    {
                        lowest = j;
                    }
                }

                if(i!=lowest)
                {
                    int temp = array[i];
                    array[i] = array[lowest];
                    array[lowest] = temp;
                }
                
            }
            return array; 
        }
    }
}
