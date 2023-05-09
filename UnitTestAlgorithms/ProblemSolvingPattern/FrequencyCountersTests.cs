using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolvingPatterns;
using Xunit;

namespace UnitTestAlgorithms.ProblemSolvingPattern
{
    public class FrequencyCountersTests
    {
        [Fact]
        public void FrequencyCounter_CheckCorrespondingSquaredElementsInTwoArrays_Pass1()
        {
            var sut = new FrequencyCounters();

            var output =
                sut.CheckCorrespondingSquaredElementsInTwoArrays(new List<int> { 1, 2, 2, 3 },
                    new List<int> { 1, 4, 4, 9 });

            Assert.True(output);
        }

        [Fact]
        public void FrequencyCounter_CheckCorrespondingSquaredElementsInTwoArrays_Fail1()
        {
            var sut = new FrequencyCounters();

            var output =
                sut.CheckCorrespondingSquaredElementsInTwoArrays(new List<int> { 1, 2, 2, 3 },
                    new List<int> { 1, 4, 9, 9 });

            Assert.False(output);
        }

        [Fact]
        public void FrequencyCounter_CheckCorrespondingSquaredElementsInTwoArrays_Fail2()
        {
            var sut = new FrequencyCounters();

            var output =
                sut.CheckCorrespondingSquaredElementsInTwoArrays(new List<int> { 1, 2, 2, 3, 4, 4 },
                    new List<int> { 1, 4, 9, 9, 16, 9 });

            Assert.False(output);
        }

        [Fact]
        public void FrequencyCounter_CheckCorrespondingSquaredElementsInTwoArrays_Pass2()
        {
            var sut = new FrequencyCounters();

            var output =
                sut.CheckCorrespondingSquaredElementsInTwoArrays(new List<int> { 2, 2, 2, 2, 5, 2, 3 },
                    new List<int> { 4, 4, 4, 4, 9, 25, 4 });

            Assert.True(output);
        }

        [Fact]
        public void FrequencyCounter_CheckIsAnagram_True1()
        {
            var sut = new FrequencyCounters();

            var output = sut.CheckIsAnagram("aabbcc", "ccbbaa");

            Assert.True(output);
        }

        [Fact]
        public void FrequencyCounter_CheckIsAnagram_False1()
        {
            var sut = new FrequencyCounters();

            var output = sut.CheckIsAnagram("avbbcc", "ccbbaa");

            Assert.False(output);
        }
    }
}
