namespace _1002._Find_Common_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CommonChars(your_input);
        }

        static private IList<string> CommonChars(string[] words)
        {
            if (words.Length == 1)
            {
                return words[0].Select(c => c.ToString()).ToList();
            }


            Dictionary<char, int> letters = new Dictionary<char, int> { };
            foreach (char c in words[0])
            {
                if (!letters.ContainsKey(c))
                {
                    letters.Add(c, 1);
                }
                else
                {
                    letters[c]++;
                }
            }

            for (int i = 1; i < words.Length; i++)
            {
                for (int j = 0; j < letters.Count; j++)
                {
                    if (!words[i].Contains(letters.ElementAt(j).Key))
                    {
                        letters.Remove(letters.ElementAt(j).Key);
                        j--;
                    }
                    else
                    {
                        if (letters.ElementAt(j).Value > words[i].Count(x => x == letters.ElementAt(j).Key))
                        {
                            letters[letters.ElementAt(j).Key] = words[i].Count(x => x == letters.ElementAt(j).Key);
                        }
                    }
                }

                if (letters.Count == 0)
                {
                    return new List<String> { };
                }
            }

            List<string> lettersR = new List<string>();
            for (int i = 0; i < letters.Count; i++)
            {
                for (int j = 0; j < letters[letters.ElementAt(i).Key]; j++)
                {
                    lettersR.Add(letters.ElementAt(i).Key.ToString());
                }
            }

            return lettersR;
        }
    }
}
