namespace _69._Sqrt_x_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MySqrt(your_input);
        }

        static private int MySqrt(int x)
        {
            double y = 100.0f;
            for (int i = 0; i < 14; i++)
            {
                y = (y + x / y) / 2.0d;
            }
            return Convert.ToInt32(Math.Floor(y));
        }
    }
}
