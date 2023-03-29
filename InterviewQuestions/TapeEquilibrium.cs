namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/3-time_complexity/tape_equilibrium/
/// </summary>
public static class TapeEquilibrium
{
    public static int Solution(int[] A)
    {
        var total = A.Sum(i => (long)i);
        long left = 0;
        var right = total;
        var diff = int.MaxValue;
        for (int i = 0; i < A.Length - 1; i++)
        {
            Console.Write($"p:{i} {left},{right}{Environment.NewLine}");
            left += A[i];
            right -= A[i];
            int newDiff = (int)Math.Abs(left - right);
            if (newDiff < diff)
            {
                diff = newDiff;
            }
        }
        return (int)diff;
    }
}
