namespace _1544._Make_The_String_Great
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MakeGood(your_input);
        }

        static private string MakeGood(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }

            int amntOfCaps = s.Where(x => char.IsUpper(x)).Count();
            int count = 0;
            bool left = false, right = false;

            while (count < amntOfCaps)
            {
                //Left to right caps
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (char.IsUpper(s[j]) && char.IsLower(s[j + 1]) && Convert.ToChar(s[j + 1].ToString().ToUpper()).Equals(s[j]))
                    {
                        s = s.Substring(0, j) + s.Substring(j + 2, s.Length - (j + 2));
                        count++;
                        left = true;
                    }
                }

                //Right to left caps
                for (int j = 1; j < s.Length; j++)
                {
                    if (char.IsUpper(s[j]) && char.IsLower(s[j - 1]) && Convert.ToChar(s[j - 1].ToString().ToUpper()).Equals(s[j]))
                    {
                        s = s.Substring(0, j - 1) + s.Substring(j + 1, s.Length - (j + 1));
                        count++;
                        right = true;
                    }
                }

                //Meaning unique
                if (!left && !right)
                {
                    return s;
                }
                left = false;
                right = false;
            }

            //Return string here
            Console.WriteLine("The string is: " + s);
            return s;
        }
    }
}
