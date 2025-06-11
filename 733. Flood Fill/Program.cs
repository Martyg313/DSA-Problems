namespace _733._Flood_Fill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FloodFill(your_input);
        }

        static private int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] == color) return image;
            int currColor = image[sr][sc]; // last color
            image[sr][sc] = color;         // new color
            connect(image, sr, sc, color, currColor);
            return image;
        }

        static private void connect(int[][] image, int sr, int sc, int color, int currColor)
        {
            if (sc - 1 >= 0 && image[sr][sc - 1] == currColor) // left
            {
                image[sr][sc - 1] = color;
                connect(image, sr, sc - 1, color, currColor);
            }

            if (sc + 1 <= image[0].Length - 1 && image[sr][sc + 1] == currColor) // right
            {
                image[sr][sc + 1] = color;
                connect(image, sr, sc + 1, color, currColor);
            }

            if (sr - 1 >= 0 && image[sr - 1][sc] == currColor) // above
            {
                image[sr - 1][sc] = color;
                connect(image, sr - 1, sc, color, currColor);
            }

            if (sr + 1 <= image.Length - 1 && image[sr + 1][sc] == currColor) // below
            {
                image[sr + 1][sc] = color;
                connect(image, sr + 1, sc, color, currColor);
            }
        }
    }
}
