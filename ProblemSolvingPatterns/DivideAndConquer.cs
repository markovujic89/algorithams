using System;

namespace ProblemSolvingPatterns
{
    public class DivideAndConquer
    {
        // Example: For given sorted array of integers, implement function (name Search) that accept value and return index of that value in to the array.
        // If value is not found, return -1
        // example input: [ 1, 3, 5, 7, 8, 8, 17], 8 return 4
        // example input: [ 1, 2, 3, 4, 5, 6, 7], 2 return 1
        // example input: [ 1, 2, 3, 4, 5, 6, 7], 21 return -1

        public int Sarch(int[] array, int inputNumber)
        {
            int min = array[0];
            int max = array[array.Length - 1];

            while (min<=max)
            {
                int middle = (int)Math.Floor((double)(min + max) / 2);

                if (array[middle] < inputNumber)
                {
                    min = middle + 1;
                }
                else if(array[middle]>inputNumber)
                {
                    max = middle - 1;
                }
                else
                {
                    return array[middle];
                }
            }

            return -1;
        }
    }
}
