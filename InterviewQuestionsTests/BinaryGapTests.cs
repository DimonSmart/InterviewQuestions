namespace InterviewQuestionsTests
{
    public class BinaryGapTests
    {
        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(32, 0)]
        [InlineData(1162,3)]
        public void CalculateBinaryGapTest1 (int n, int gap)
        {
            Assert.Equal(gap, BinaryGap.Solution1(n));
        }

        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(32, 0)]
        [InlineData(1162, 3)]
        public void CalculateBinaryGapTest2(int n, int gap)
        {
            Assert.Equal(gap, BinaryGap.Solution2(n));
        }
    }
}