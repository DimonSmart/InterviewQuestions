namespace InterviewQuestionsTests;

public class PassingCarsTests
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 1, 1 }, 5)]
    public void PassingCarTest(int[] a, int expected)
    {
        Assert.Equal(expected, PassingCars.Solution(a));
    }
}
