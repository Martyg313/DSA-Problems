namespace _744._Find_Smallest_Letter_Greater_Than_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NextGreatestLetter(your_input);
        }

        static private char NextGreatestLetter(char[] letters, char target)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i].CompareTo(target) > 0)
                {
                    return letters[i];
                }
            }
            return letters[0];
        }
    }
}
