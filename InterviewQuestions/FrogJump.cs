namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
/// </summary>
public static class FrogJump
{
    public static int Solution(int X, int Y, int D)
    {
        var distance = Y - X;
        return (distance / D) + (distance % D == 0 ? 0 : 1);
    }
}
