namespace InterviewQuestionsTests;

public class TapeEquilibriumTests
{
    [Theory]
    [InlineData(new int[] { 3, 1, 2, 4, 1 }, 1)]
    [InlineData(new int[] { -10, 10 }, 20)]
    public void TapeEquilibriumTest(int[] a, int expected)
    {
        Assert.Equal(expected, TapeEquilibrium.Solution(a));
    }
}
