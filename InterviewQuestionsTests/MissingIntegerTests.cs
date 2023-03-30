namespace InterviewQuestionsTests;

public class MissingIntegerTests
{
    [Theory]
    [InlineData(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
    [InlineData(new int[] { 1, 2, 3 }, 4)]
    [InlineData(new int[] { -1, -2 }, 1)]
    public void MissingIntegerTest(int[] a, int expected)
    {
        Assert.Equal(expected, MissingInteger.Solution(a));
    }
}
