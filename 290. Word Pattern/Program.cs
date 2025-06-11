namespace _290._Word_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WordPattern(your_input);
        }

        static private bool WordPattern(string pattern, string s)
        {
            char[] chars = pattern.ToCharArray();
            string[] words = s.Split(' ');

            if (chars.Length != words.Length)
            {
                return false;
            }

            Dictionary<char, string> Pairs = new Dictionary<char, string>();

            for (int i = 0; i < chars.Length; i++)
            {
                if (!Pairs.ContainsKey(chars[i]))
                {
                    if (Pairs.ContainsValue(words[i]))
                    {
                        return false;
                    }
                    else
                    {
                        Pairs.Add(chars[i], words[i]);
                    }
                }
                else
                {
                    if (!Pairs[chars[i]].Equals(words[i]))
                    {
                        return false;
                    }
                }

            }

            return true;
        }
    }
}
