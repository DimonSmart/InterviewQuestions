namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/6-sorting/distinct/
/// </summary>
public static class Distinct
{
      public static int Solution(int[] A)
      {
          return A.Distinct().Count();
      }
}
