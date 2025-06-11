namespace _541._Reverse_String_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReverseStr(your_input);
        }

        static private string ReverseStr(string s, int k)
        {
            if (k == 1) // return the word with no changes
            {
                return s;
            }
            else if (k >= s.Length) // Reverse the whole word
            {
                return string.Concat(s.Reverse());
            }
            else // Reverse normaly
            {
                char[] chars = s.ToCharArray();
                bool reverse = true;

                for (int i = 0; i < s.Length; i += k)
                {
                    if (reverse) // reverse letters in sub-group
                    {
                        if (s.Length - i < k)
                        {
                            k = s.Length - i;
                        }

                        char[] reversedChars = s.Substring(i, k).Reverse().ToArray();

                        for (int j = 0; j < k; j++)
                        {
                            chars[i + j] = reversedChars[j];
                        }
                        reverse = false;
                    }
                    else // no changes
                    {
                        reverse = true;
                    }
                }

                return string.Concat(chars);
            }
        }
    }
}
