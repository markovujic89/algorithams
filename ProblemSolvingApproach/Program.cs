using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingApproach
{
    class Program
    {
        static void Main(string[] args)
        {
            Examples examles = new Examples();

            examles.PrintCountCharactests(examles.CountCharactests("sssssc  ccccc ## bbbvcv 77"));

            Console.ReadLine();
        }
    }
}
