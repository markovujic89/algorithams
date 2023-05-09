using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FrequencyCounters frequencyCounters = new FrequencyCounters();

            frequencyCounters.CheckCorrespondingSquaredElementsInTwoArrays(new List<int> { 2, 2, 3, 4, 4 },
                new List<int> { 4, 4, 4, 9, 16 });

            Console.ReadLine();
        }
    }
}
