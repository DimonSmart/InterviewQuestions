namespace InterviewQuestionsTests
{
    public class PermMissingElemTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 5 }, 4)]
        public void FrogJumpTest(int []a, int expected)
        {
            Assert.Equal(expected, PermMissingElem.Solution(a));
        }
    }
}