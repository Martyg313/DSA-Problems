namespace _20._Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsValid(your_input);
        }

        public bool IsValid(string s)
        {
            Stack<char> p = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    p.Push(s[i]);
                }
                else
                {
                    // If there is nothing to pop, then false
                    if (p.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        // Comparison for popping
                        if ((int)s[i] == (int)p.Peek() + 1 || (int)s[i] == (int)p.Peek() + 2)
                        {
                            p.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            // If stack is not empty, then false
            if (p.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
