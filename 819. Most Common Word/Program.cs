namespace _819._Most_Common_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MostCommonWord(your_input);
        }

        static private string MostCommonWord(string paragraph, string[] banned)
        {
            int lengthProper = paragraph.Length;
            for (int i = 0; i < lengthProper; i++)
            {
                if (paragraph[i].Equals(',') || paragraph[i].Equals('.') || paragraph[i].Equals('!') || paragraph[i].Equals('?') || paragraph[i].Equals(';') || paragraph[i].Equals('\''))
                {
                    if (i > 0 && i < paragraph.Length - 1 && !paragraph[i - 1].Equals(' ') && !paragraph[i + 1].Equals(' '))
                    {
                        paragraph = paragraph.Substring(0, i) + " " + paragraph.Substring(i + 1, paragraph.Length - 1 - i);
                    }
                    else
                    {
                        paragraph = paragraph.Remove(i, 1);
                        i--;
                        lengthProper--;
                    }
                }
            }

            string[] splitParagraph = paragraph.Split(' ');

            Dictionary<string, int> uniques = new Dictionary<string, int> { };
            for (int i = 0; i < splitParagraph.Length; i++)
            {
                if (!uniques.ContainsKey(splitParagraph[i].ToLower()))
                {
                    uniques.Add(splitParagraph[i].ToLower(), 1);
                }
                else
                {
                    uniques[splitParagraph[i].ToLower()]++;
                }
            }

            for (int i = 0; i < banned.Length; i++)
            {
                if (uniques.ContainsKey(banned[i]))
                {
                    uniques.Remove(banned[i]);
                }
            }

            int g = uniques.Values.Max();
            return uniques.FirstOrDefault(x => x.Value == uniques.Values.Max()).Key;
        }
    }
}
