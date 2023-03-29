namespace InterviewQuestionsTests
{
    public class FrogRiverOneTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 5, 6)]
        public void FrogRiverOneTest(int[] a, int x, int expected)
        {
            Assert.Equal(expected, FrogRiverOne.Solution(x, a));
        }
    }
}