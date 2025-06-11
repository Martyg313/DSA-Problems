namespace _492._Construct_the_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConstructRectangle(your_input);
        }

        static private int[] ConstructRectangle(int area)
        {
            for (int i = Convert.ToInt32(Math.Sqrt(area)); i > 0; i--)
            {
                if (area % i == 0)
                {
                    return new int[] { area / i, i };
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
