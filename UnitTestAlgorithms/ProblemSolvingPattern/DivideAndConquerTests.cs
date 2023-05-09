using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolvingPatterns;
using Xunit;

namespace UnitTestAlgorithms.ProblemSolvingPattern
{
    public class DivideAndConquerTests
    {
        [Fact]
        public void Search_InputArray_ReturnRigtIndex()
        {
            var sut = new DivideAndConquer();

            var output = sut.Sarch(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9);

            Assert.True(output==9);
        }
    }
}
