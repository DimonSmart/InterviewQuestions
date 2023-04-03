namespace InterviewQuestionsTests
{
    public class CountDivTests
    {
        [Theory]
        [InlineData(6, 11, 2, 3)]
        [InlineData(11, 345, 17, 20)]
        public void CountDivTest(int a, int b, int k, int expected)
        {
            Assert.Equal(expected, CountDiv.Solution(a, b, k));
        }
    }
    
}