using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolvingApproach;
using Xunit;

namespace UnitTestAlgorithms.ProblemSolvingApproach
{
    public class ExamplesTests
    {
        [Fact]
        public void CountCharactestsGetCountForA()
        {
            // arrange
            var sut = new Examples();

            // act
            var output = sut.CountCharactests("aaaa");

            // assert
            Assert.True(output['a'] == 4);
        }

        [Fact]
        public void CountCharactestsGetCountForB()
        {
            // arrange
            var sut = new Examples();

            // act
            var output = sut.CountCharactests("111 22 bbb bbb");

            // assert
            Assert.True(output['b'] == 6);
        }
    }
}
