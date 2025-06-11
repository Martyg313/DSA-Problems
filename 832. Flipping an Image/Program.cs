namespace _832._Flipping_an_Image
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FlipAndInvertImage(your_input);
        }

        static private int[][] FlipAndInvertImage(int[][] image)
        {
            int data;

            // Horizontal flip
            for (int j = 0; j < image.Length; j++)
            {
                for (int i = 0; i < image[0].Length / 2; i++)
                {
                    data = image[j][image[0].Length - 1 - i];
                    image[j][image[0].Length - 1 - i] = image[j][i];
                    image[j][i] = data;
                }
            }

            // Invert
            for (int j = 0; j < image.Length; j++)
            {
                for (int i = 0; i < image[0].Length; i++)
                {
                    if (image[j][i] == 0)
                    {
                        image[j][i] = 1;
                    }
                    else
                    {
                        image[j][i] = 0;
                    }
                }
            }

            return image;
        }
    }
}
