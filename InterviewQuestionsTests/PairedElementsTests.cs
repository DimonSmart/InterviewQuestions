namespace InterviewQuestionsTests
{
    public class PairedElementsTests
    {
        [Theory]
        [InlineData(new int[] { 9, 3, 9, 3, 7 }, 7)]
        public void PairedElementsTest(int[] a, int expected)
        {
            Assert.Equal(expected, OddOccurrencesInArray.Solution(a));
        }
    }
}