namespace _520._Detect_Capital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DetectCapitalUse(your_input);
        }

        static private bool DetectCapitalUse(string word)
        {
            if (word.All(x => char.IsLower(x)))  // All lower case
            {
                return true;
            }
            else if (word.All(x => char.IsUpper(x)))  // All upper case
            {
                return true;
            }
            else if (char.IsUpper(word[0]) && word.Substring(1, word.Length - 1).All(x => char.IsLower(x)))  //Only first       letters is capatalised
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
