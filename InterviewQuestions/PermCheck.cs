namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
/// </summary>
public static class PermCheck
{
    public static int Solution(int[] A)
    {
        return A.Length == A.Distinct().Count() && A.Max() == A.Length ? 1 : 0;
    }
}
