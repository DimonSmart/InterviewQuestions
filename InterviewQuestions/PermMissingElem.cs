namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
/// </summary>
public static class PermMissingElem
{
    public static int Solution(int[] A)
    {
        long l = A.Length;
        if (l == 0) return 1;

        long sum = A.Sum(i => (long)i);
        long x = (l + 1L) * (l + 1 + 1) / 2;
        return (int)(x - sum);
    }
}
