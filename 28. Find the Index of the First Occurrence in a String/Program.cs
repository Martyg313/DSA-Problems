namespace _28._Find_the_Index_of_the_First_Occurrence_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StrStr(your_input);
        }

        static private int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length).Equals(needle))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
