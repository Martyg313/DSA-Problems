namespace _2273._Find_Resultant_Array_After_Removing_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RemoveAnagrams(your_input);
        }

        static public IList<string> RemoveAnagrams(string[] words)
        {
            List<string> result = new List<string>();
            result.Add(words[0]);

            for (int i = 1; i < words.Length; i++)
            {
                if (!AreAnagrams(result[result.Count - 1], words[i]))
                {
                    result.Add(words[i]);
                }
            }

            return result;
        }

        static private bool AreAnagrams(string word1, string word2)
        {
            if (word1.Length != word2.Length) return false;

            char[] chars1 = word1.ToCharArray();
            char[] chars2 = word2.ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            return new string(chars1) == new string(chars2);
        }
    }
}
