namespace InterviewQuestionsTests;

public class MinAvgTwoSliceTests
{
    [Theory]
    [InlineData(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 1)]
    public void MinAvgTwoSliceTest(int[] a, int expected)
    {
        Assert.Equal(expected, MinAvgTwoSlice.Solution(a));
    }
}
