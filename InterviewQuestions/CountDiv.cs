namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/5-prefix_sums/count_div/
/// </summary>
public static class CountDiv
{
    public static int Solution(int A, int B, int K)
    {
        return B / K - A / K + (A % K == 0 ? 1 : 0);
    }
}