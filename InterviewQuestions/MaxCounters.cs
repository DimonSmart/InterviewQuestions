namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/
/// </summary>
public static class MaxCounters
{
    public static int[] Solution(int N, int[] A)
    {
        var m = new int[N];
        var max = 0;
        var maxApplied = 0;
        var applyMaxNumber = N + 1;

        foreach (var a in A)
        {
            var idx = a - 1;
            Console.WriteLine(string.Join(",", m));
            if (a == applyMaxNumber)
            {
                maxApplied = max;
                continue;
            }

            if (m[idx] < maxApplied)
            {
                m[idx] = maxApplied;
            }

            var value = ++m[idx];
            if (value > max)
            {
                max = value;
            }
        }

        for (int i = 0; i < N; i++)
        {
            if (m[i] < maxApplied)
            {
                m[i] = maxApplied;
            }
        }

        return m;
    }
}
