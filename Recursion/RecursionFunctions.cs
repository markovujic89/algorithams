using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class RecursionFunctions
    {
        public void CountDown(int startNumber)
        {
            if (startNumber <= 0)
            {
                Console.WriteLine("All done");
                return;
            }

            Console.WriteLine(startNumber);
            startNumber--;
            CountDown(startNumber);
        }

        public int CalculateFactorial(int number)
        {
            int sum = 1;

            for (int i = number; i > 0; i--)
            {
                sum *= i;
            }

            return sum;
        }

        // Helper method recursion
        public List<int> CollectOddValues(List<int> values)
        {
            List<int> results = new List<int>();

            HelperRecursionFunction(ref values, results);

            return results;
        }

        private void HelperRecursionFunction(ref List<int> values, List<int> results)
        {
            if (values.Count == 0)
            {
                return;
            }

            if (values[0] % 2 != 0)
            {
                results.Add(values[0]);
            }

            if (values.Count > 0)
            {
                values.RemoveAt(0);
                HelperRecursionFunction(ref values, results);
            }
            
        }

    }
}
