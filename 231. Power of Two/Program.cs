namespace _231._Power_of_Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsPowerOfTwo(your_input);
        }

        static private bool IsPowerOfTwo(int n)
        {
            if (n == 0)
            {
                return false;
            }

            int total = 1;
            while (total < n)
            {
                if (total == 1073741824)
                {
                    return false;
                }
                else
                {
                    total *= 2;
                }
            }

            if (total > n)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
