namespace day9_extension{
public static class Palindrome
{
    public static bool CheckPalindrome(this string ss)
    {
        if (string.IsNullOrWhiteSpace(ss))
        {
            return false;
        }

        int s= 0;
        int e=ss.Length-1;

        while (s < e)
        {
            if (ss[s] != ss[e])
            {
                return false;
            }
            s++;
            e--;
        }
        return true;

    }
}
}