using System;

namespace ProblemSolvingPatterns
{
    public class SlidingWindow
    {
        // example: write array called maxSubArraySum witch accept array of integers, and number called n.
        // The function should calculate the maximum sum of n consecutive elements in the array.
        // example [1, 1, 4, 5, 2, 2], n =2   output: 9
        // example: [2, 3, 1, 1, 7, 8, 6, 1, 7, 2, 4] n =3   output: 21

        public int MaxSubArraySum(int[] array, int number)
        {
            var maxSum = 0;
            var tempSum = 0;

            for (int i = 0; i < number; i++)
            {
                maxSum += array[i];
            }

            tempSum = maxSum;
            for (int k = number; k < array.Length; k++)
            {
                tempSum = tempSum - array[k - number] + array[k];

                maxSum = Math.Max(maxSum, tempSum);
            }

            return maxSum;
        }
    }
}
