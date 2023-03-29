namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
/// </summary>
public static class FrogRiverOne
{
    public static int Solution(int X, int[] A)
    {
        var b = new HashSet<int>();
        for (var i = 0; i < A.Length; i++)
        {

            b.Add(A[i]);
            if (b.Count == X)
            {
                return i;
            }
        }
        return -1;
    }
}
