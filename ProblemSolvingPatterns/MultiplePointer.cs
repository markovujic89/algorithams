using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPatterns
{
    public class MultiplePointer
    {
        // Example: write a function called SumZero which accepted sorted array of integers
        // and function should return the first pair where the sum is 0. Return an array that include both values that sum is zero, or empty array

        // example: [-3, -2, -1, 0, 2, -3]   return [-3, 3]
        // example: [-3, 0, 1, 4]  return empty array
        // example: [1, 2, 3] return empty array

        public int[] SumZero(int[] inputArray)
        {
            int leftIndex = 0;
            int rightIndex = inputArray.Length - 1;

            while (leftIndex < rightIndex)
            {
                var sum = inputArray[leftIndex] + inputArray[rightIndex];

                if (sum == 0)
                {
                    return new int[2] { inputArray[leftIndex], inputArray[rightIndex] };
                }

                if (sum > 0)
                {
                    rightIndex--;
                }

                if (sum < 0)
                {
                    leftIndex++;
                }
                
            }
            return null;
        }


        // example: implement function CountUniqueValues, input sorted array, output: counts unique values in array
        // example: [1, 1, 2, 3, 3, 3, 3] output: 3
        // example [-2, 3, 4, 5, 5, 6, 9] output: 6
        // example: [ 0, 0, 0, 0, 0, 3] output: 2

        public int CountUniqueValues(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            
            int k = 0;
            int count = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array[k])
                {
                    k++;
                    array[k] = array[i];
                }
            }

            return k+1;
        }
    }
}
