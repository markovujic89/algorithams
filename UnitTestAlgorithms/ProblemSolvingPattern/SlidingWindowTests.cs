using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolvingPatterns;
using Xunit;

namespace UnitTestAlgorithms.ProblemSolvingPattern
{
    public class SlidingWindowTests
    {
        [Fact]
        public void MaxSubArraySum_NumberEqual2_ReturnMax()
        {
            var sut = new SlidingWindow();

            var output = sut.MaxSubArraySum(new int[7] { 2, 2, 4, 8, 7, 3, 1 }, 3);

            Assert.True(output==19);
        }

        [Fact]
        public void MaxSubArraySum_NumberEqual2_ReturnMax1()
        {
            var sut = new SlidingWindow();

            var output = sut.MaxSubArraySum(new int[7] { 1, 5, 9, 8, 2, 10, 1 }, 3);

            Assert.True(output == 22);
        }

        [Fact]
        public void MaxSubArraySum_NumberEqual2_ReturnMax2()
        {
            var sut = new SlidingWindow();

            var output = sut.MaxSubArraySum(new int[7] { 0, 12, 1, 2, 3, 6, 1 }, 3);

            Assert.True(output == 13);
        }
    }
}
