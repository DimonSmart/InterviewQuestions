namespace InterviewQuestionsTests
{
    public class GenomicRangeQueryTests
    {
        [Theory]
        [InlineData("CAGCCTA", new[] { 2, 5, 0 }, new[] { 4, 5, 6 }, new[] { 2, 4, 1 })]

        public void GenomicRangeQueryTest(string s, int[] p, int[] q, int[] expected)
        {
            Assert.Equal(expected, GenomicRangeQuery.Solution(s, p, q));
        }
    }
}