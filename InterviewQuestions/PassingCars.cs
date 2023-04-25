namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
/// </summary>
public static class PassingCars
{
    public static int Solution(int[] A)
    {
        var left = 0;
        var pass = 0;

        foreach (var a in A)
        {
            if (a == 0)
            {
                left++;
                continue;
            }
            pass += left;
            if (pass > 1_000_000_000)
            {
                return -1;
            }

        }

        return pass;
    }
}
