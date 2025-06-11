namespace _242._Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsAnagram(your_input);
        }

        static private bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] letters = s.ToArray();
            Array.Sort(letters);
            char[] lettersTwo = t.ToArray();
            Array.Sort(lettersTwo);

            return Enumerable.SequenceEqual(letters, lettersTwo);
        }
    }
}
