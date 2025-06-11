namespace _70._Climbing_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClimbStairs(your_input);
        }

        static private int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else if (n == 3)
            {
                return 3;
            }
            int[] ways = new int[n];
            ways[0] = 1;
            ways[1] = 2;
            ways[2] = 3;
            for (int i = 3; i < n; i++)
            {
                ways[i] = ways[i - 1] + ways[i - 2];
            }
            return ways[n - 1];
        }
    }
}
