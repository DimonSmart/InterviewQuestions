namespace InterviewQuestionsTests
{
    public class PermCheckTests
    {
        [Theory]
        [InlineData(new int[] { 4, 1, 3, 2 }, 1)]
        [InlineData(new int[] { 4, 1, 3 }, 0)]
        public void PermCheckTest(int[] a, int expected)
        {
            Assert.Equal(expected, PermCheck.Solution(a));
        }
    }
}