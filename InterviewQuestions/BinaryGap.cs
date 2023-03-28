using System.Text.RegularExpressions;

namespace InterviewQuestions;

/// <summary>
/// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
/// </summary>
public static class BinaryGap
{
    public static int Solution1(int n)
    {
        const int maxLength = sizeof(int) * 10;
        string zeroes = new string('0', maxLength);
        string s = zeroes + "X";
        for (int i = 0; i <= sizeof(int) * 8; i++)
        {
            s = (((n & 1) == 0) ? "0" : "1") + s;
            n = n >> 1;
        }
        s = "X" + zeroes + s;

        return s.Split("1")
                .Select(s => s.Length)
                .Where(l => l < maxLength)
                .OrderByDescending(l => l)
                .FirstOrDefault();
    }

    public static int Solution2(int n)
    {
        string s = "X";
        for (int i = 0; i <= sizeof(int) * 8; i++)
        {
            s = (((n & 1) == 0) ? "0" : "11") + s;
            n >>= 1;
        }
        s = "X" + s;
        var matches = Regex.Matches(s, "10+1");

        return matches.Any() ? matches.Select(m => m.Length).OrderByDescending(l => l).FirstOrDefault() - 2 : 0;
    }

}