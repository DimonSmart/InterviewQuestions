namespace InterviewQuestionsTests
{
    public class ArrayShiftTests
    {
        [Theory]
        [InlineData(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [InlineData(new int[] { 0, 0, 0 }, 3, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        public void ArrayShiftTest(int[] a, int k, int[] expected)
        {
            Assert.Equal(expected, CyclicRotation.Solution(a, k));
        }
    }
}