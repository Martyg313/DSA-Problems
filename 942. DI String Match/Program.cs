namespace _942._DI_String_Match
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DiStringMatch(your_input);
        }

        static private int[] DiStringMatch(string s)
        {
            int[] perm = new int[s.Length + 1];

            int min = 0, max = s.Length;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('I'))
                {
                    perm[i] = min;
                    min++;
                }
                else
                {
                    perm[i] = max;
                    max--;
                }
            }
            perm[perm.Length - 1] = min;

            return perm;
        }
    }
}
