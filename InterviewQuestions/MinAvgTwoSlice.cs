namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/5-prefix_sums/min_avg_two_slice/
/// </summary>
public static class MinAvgTwoSlice
{
       public static int Solution(int[] A)
        {
            // Implement your solution here

            var minPos = int.MinValue;
            var minValue = double.MaxValue;


            for (int i = 0; i < A.Length - 1; i++)
            {
                var a2 = (A[i] + A[i + 1]) / 2.0;
                if (a2 < minValue)
                {
                    minValue = a2;
                    minPos = i;
                }

                if (i < A.Length - 2)
                {

                    var a3 = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    if (a3 < minValue)
                    {
                        minValue = a3;
                        minPos = i;
                    }
                }
            }
            return minPos;
        }

}
