using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigO_Notation.Examples;

namespace BigO_Notation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example 1");
            NumbersCalculator numbersCalculator = new NumbersCalculator();
            // worst solution
            int r1 = numbersCalculator.CalculateNumbers(10);

            int r2 = numbersCalculator.CalculateNumberBetterSolution(10);

            Console.WriteLine($"Worst solution {r1}, Better solution {r2}");


            Console.WriteLine("Example 2");
            numbersCalculator.LogLeastFive(9);
            Console.ReadLine();
        }

        
    }
}
