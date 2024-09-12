namespace Dummy.Library;

public static class PartiallyCovered
{
    public static char FirstChar(string s)
    {
        return s[0];
    }

    public static double ToDouble(int n)
    {
        return (double)n;
    }

    public static string Repeat(char c, int times)
    {
        return new string(c, times);
    }

    public static int CountChars(string s)
    {
        return s.Length;
    }

#pragma warning disable CS8603 // Possible null reference return.
    public static TTo UnsafeCast<TFrom, TTo>(TFrom t) where TTo: class
    {
        return t as TTo;
    }
#pragma warning restore CS8603 // Possible null reference return.

    public static int ComputeBadHash(object _)
    {
        return 42;
    }
}
