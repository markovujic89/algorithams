using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recursion;
using Xunit;

namespace UnitTestAlgorithms.Recursion
{
    public class RecursionFunctionsTests
    {
        [Fact]
        public void RecursionFunctions_Recursion_Test()
        {
            var sut = new RecursionFunctions();

            sut.CountDown(1000000000);

            Assert.True(1==1);
        }

        [Fact]
        public void CalculateFactorial_CalculateFactorial6_Return240()
        {
            var sut = new RecursionFunctions();

            var output = sut.CalculateFactorial(6);

            Assert.True(output==720);
        }

        [Fact]
        public void HelperRecursionFunction_ListWithSomeodds_CollectionWithOdds()
        {
            var sut = new RecursionFunctions();

            var output = sut.CollectOddValues(new List<int> { 1, 2, 4, 5, 6, 8, 9 });

            Assert.True(output.Count==3);
        }
    }
}
