namespace _748._Shortest_Completing_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ShortestCompletingWord(your_input);
        }

        static private string ShortestCompletingWord(string licensePlate, string[] words)
        {
            // prepare letters
            List<char> letters = new List<char>();
            foreach (char letter in licensePlate)
            {
                if (!(letter == ' ' || char.IsDigit(letter)))
                    letters.Add(char.ToLower(letter));
            }

            // group valid words in list
            List<string> ValidWords = new List<string>();
            foreach (var word in words)
            {
                if (isMatch(letters, word))
                    ValidWords.Add(word);
            }

            // returning shortest word

            string smallestWord = ValidWords[0];
            foreach (string word in ValidWords)
            {
                if (word.Length < smallestWord.Length)
                {
                    smallestWord = word;
                }
            }

            return smallestWord;
        }

        static private bool isMatch(List<char> letters, string word)
        {
            foreach (var letter in letters)
            {
                if (!word.Contains(letter))
                    return false;

                word = word.Remove(word.IndexOf(letter), 1);
            }
            return true;
        }
    }
}
