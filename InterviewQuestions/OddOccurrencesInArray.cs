namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
/// </summary>
public static class OddOccurrencesInArray
{
    public static int Solution(int[] A)
    {
        // Implement your solution here
        int i = 0;
        foreach (var j in A)
        {
            i ^= j;
        }
        return i;
    }
}
