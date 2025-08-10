namespace _11._Container_With_Most_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MaxArea(your_input);
        }

        public int MaxArea(int[] height)
        {
            int first = 0, second = height.Length - 1, max = 0;

            while (first < second)
            {
                int difference = second - first;
                int area = 0;
                if (height[first] >= height[second])
                {
                    area = height[second] * difference;
                    second -= 1;
                }
                else
                {
                    area = height[first] * difference;
                    first += 1;
                }
                if (area > max)
                    max = area;
            }

            return max;
        }
    }
}
