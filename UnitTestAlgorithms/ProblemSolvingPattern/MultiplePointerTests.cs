using ProblemSolvingPatterns;
using Xunit;

namespace UnitTestAlgorithms.ProblemSolvingPattern
{
    public class MultiplePointerTests
    {
        [Fact]
        public void SumZero_ArrayWithPair_Pair1()
        {
            var sut = new MultiplePointer();

            var output = sut.SumZero(new int[4] { -2, 0, 1, 2 });

            Assert.True(output.Length == 2);
        }

        [Fact]
        public void SumZero_ArrayWithoutPair_Null()
        {
            var sut = new MultiplePointer();

            var output = sut.SumZero(new int[4] { -2, 0, 1, 5 });

            Assert.True(output == null);
        }

        [Fact]
        public void SumZero_ArrayWithPair_Pair2()
        {
            var sut = new MultiplePointer();

            var output = sut.SumZero(new int[9] { -3, 0, 1, 2, 3, 5, 7, 8, 9 });

            Assert.True(output.Length == 2);
        }

        [Fact]
        public void SumZero_ArrayWithPair_Pair3()
        {
            var sut = new MultiplePointer();

            var output = sut.SumZero(new int[8] { -4, 0, 1, 2, 4, 9, 21, 33 });

            Assert.True(output.Length == 2);
        }

        [Fact]
        public void CountUniqueValues_Return3()
        {
            var sut = new MultiplePointer();

            var output = sut.CountUniqueValues(new int[6] { 1, 1, 2, 2, 3, 3 });

            Assert.True(output == 3);
        }
    }
}
