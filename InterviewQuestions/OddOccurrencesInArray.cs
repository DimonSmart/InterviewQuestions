namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
/// </summary>
public static class OddOccurrencesInArray
{
    public static int Solution(int[] A)
    {
        return A.Aggregate(0, (acc, num) => acc ^ num);
    }
}
