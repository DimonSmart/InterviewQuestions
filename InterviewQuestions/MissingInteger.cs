namespace InterviewQuestions;

public static class MissingInteger
{
    public static int Solution(int[] A)
    {
        var a = A.Where(i => i > 0).OrderBy(i => i);
        var missingNumber = 1;
        foreach (var i in a)
        {
            if (i == missingNumber)
            {
                missingNumber++;
                continue;
            }
            if (i > missingNumber)
            {
                return missingNumber;
            }
        }
        return missingNumber;
    }
}
