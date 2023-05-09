using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.Examples
{
    public class NumbersCalculator
    {
        public int CalculateNumbers(int number)
        {
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                sum += i;
            }

            return sum;
        }

        public int CalculateNumberBetterSolution(int number)
        {
            return number * (number + 1) / 2;
        }

        /// <summary>
        /// Big O notation complexity: O(n)
        /// </summary>
        /// <param name="n"></param>
        public void LogLeastFive(int n)
        {
            Console.WriteLine("Log least five");
            Console.WriteLine("======================");
            for (int i = 0; i <= Math.Max(5,n); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
