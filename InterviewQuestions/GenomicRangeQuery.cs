namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/5-prefix_sums/genomic_range_query/
/// </summary>
public static class GenomicRangeQuery
{
    public static int[] Solution(string S, int[] P, int[] Q)
    {
        // Implement your solution here
        var A = new int[S.Length];
        var C = new int[S.Length];
        var G = new int[S.Length];
        var T = new int[S.Length];
        int a = 0, c = 0, g = 0, t = 0;
        for (var i = 0; i < S.Length; i++)
        {
            switch (S[i])
            {
                case 'A':
                    a += 1;
                    break;
                case 'C':
                    c += 1;
                    break;
                case 'G':
                    g += 1;
                    break;
                case 'T':
                    t += 1;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }

            A[i] = a; C[i] = c; G[i] = g; T[i] = t;
        }

        var result = new List<int>();
        for (int i = 0; i < P.Length; i++)
        {
            var start = P[i];
            var end = Q[i];

            if (A[start] < A[end] || S[start] == 'A')
            {
                result.Add(1);
                continue;
            }

            if (C[start] < C[end] || S[start] == 'C')
            {
                result.Add(2);
                continue;
            }

            if (G[start] < G[end] || S[start] == 'G')
            {
                result.Add(3);
                continue;
            }

            if (T[start] < T[end] || S[start] == 'T')
            {
                result.Add(4);
                continue;
            }
        }
        return result.ToArray();
    }
}