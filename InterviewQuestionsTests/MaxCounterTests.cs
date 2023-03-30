namespace InterviewQuestionsTests
{
    public class MaxCounterTests
    {
        [Theory]
        [InlineData(new int[] { 3, 4, 4, 6, 1, 4, 4 }, 5, new int[] { 3, 2, 2, 4, 2 })]
        public void MaxCounterTest(int[] a, int n, int[] expected)
        {
            Assert.Equal(expected, MaxCounters.Solution(n, a));
        }
    }
}