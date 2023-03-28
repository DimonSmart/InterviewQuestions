namespace InterviewQuestionsTests
{
    public class FrogJumpTests
    {
        [Theory]
        [InlineData(10, 85, 30, 3)]
        public void FrogJumpTest(int x, int y, int d, int expected)
        {
            Assert.Equal(expected, FrogJump.Solution(x, y, d));
        }
    }
}