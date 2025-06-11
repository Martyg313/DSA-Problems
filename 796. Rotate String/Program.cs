namespace _796._Rotate_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RotateString(your_input);
        }

        static private bool RotateString(string s, string goal)
        {
            if (s.Length != goal.Length)   // If they don't have the same length then return false
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s.Equals(goal))
                {
                    return true;
                }
                s = s.Substring(1, s.Length - 1) + s[0];
            }

            return false;
        }
    }
}
