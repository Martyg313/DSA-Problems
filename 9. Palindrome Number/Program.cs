namespace _9._Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsPalindrome();
        }

        static private bool IsPalindrome(int x)
        {
            string xString = x.ToString();
            for (int i = 0; i < xString.Length / 2; i++)
            {
                if (xString[i] != xString[xString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
