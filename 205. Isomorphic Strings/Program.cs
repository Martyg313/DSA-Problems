namespace _205._Isomorphic_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsIsomorphic(your_input);
        }

        static private bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> keyValuePairsTop = new Dictionary<char, char>();
            Dictionary<char, char> keyValuePairsBot = new Dictionary<char, char>();

            bool uniqueOne = false;
            bool uniqueTwo = false;

            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    keyValuePairsTop.Add(s[i], t[i]);
                }
                catch (Exception e)
                {
                    if (!t[i].Equals(keyValuePairsTop[s[i]]))
                    {
                        uniqueOne = true;
                        //return false;
                    }
                }
            }



            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    keyValuePairsBot.Add(t[i], s[i]);
                }
                catch (Exception e)
                {
                    if (!s[i].Equals(keyValuePairsBot[t[i]]))
                    {
                        uniqueTwo = true;
                        //return false;
                    }
                }
            }

            if (uniqueOne == true || uniqueTwo == true)
            {
                return false;
            }
            return true;
        }
    }
}
