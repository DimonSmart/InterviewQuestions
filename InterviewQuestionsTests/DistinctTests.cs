namespace InterviewQuestionsTests
{
    public class DistinctTests
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 1, 2, 3, 1 }, 3)]
        public void DistinctTest(int[] a, int expected)
        {
            Assert.Equal(expected, Distinct.Solution(a));
        }
    }
}