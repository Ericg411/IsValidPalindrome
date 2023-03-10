namespace IsValidPalindrome;
public class Class1
{
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();
        char[] chars = s.ToCharArray();
        string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
        List<char> pal = new List<char>();

        foreach (char c in chars)
        {
            if (pool.Contains(c))
            {
                pal.Add(c);
            }
        }

        string result = new string(pal.ToArray());
        pal.Reverse();
        string reversedResult = new string(pal.ToArray());

        if (result == reversedResult)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
