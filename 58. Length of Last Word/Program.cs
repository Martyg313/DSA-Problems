namespace _58._Length_of_Last_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LengthOfLastWord(your_input);
        }

        static private int LengthOfLastWord(string s)
        {
            s = s.Trim();
            int count = 0;
            for (int i = s.Length - 1; i > -1; i--)
            {
                if (s[i].Equals(' '))
                {
                    return count;
                }
                count++;
            }
            return count;
        }
    }
}
