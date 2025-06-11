namespace _13._Roman_to_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RomanToInt(your_input);
        }

        static private int RomanToInt(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('M'))
                {
                    result += 1000;
                }
                else if (s[i].Equals('D'))
                {
                    result += 500;
                }
                else if (s[i].Equals('C'))
                {
                    result += 100;
                }
                else if (s[i].Equals('L'))
                {
                    result += 50;
                }
                else if (s[i].Equals('X'))
                {
                    result += 10;
                }
                else if (s[i].Equals('V'))
                {
                    result += 5;
                }
                else if (s[i].Equals('I'))
                {
                    result += 1;
                }
            }

            if (s.Contains("CM"))
            {
                result -= 200;
            }
            if (s.Contains("CD"))
            {
                result -= 200;
            }
            if (s.Contains("XC"))
            {
                result -= 20;
            }
            if (s.Contains("XL"))
            {
                result -= 20;
            }
            if (s.Contains("IX"))
            {
                result -= 2;
            }
            if (s.Contains("IV"))
            {
                result -= 2;
            }
            return result;
        }
    }
}
