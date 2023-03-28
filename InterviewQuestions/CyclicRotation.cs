namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
/// </summary>
public static class CyclicRotation
{
    public static int[] Solution(int[] A, int K)
    {
        if (A.Length == 0) return A;
        var actual = K % A.Length;
        if (actual == 0) return A;

        var result = A.Reverse().Take(actual).Reverse().ToList();
        result.AddRange(A.Take(A.Length - actual));
        return result.ToArray();
    }
}
