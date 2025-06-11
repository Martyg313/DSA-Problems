namespace _605._Can_Place_Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CanPlaceFlowers(your_input);
        }

        static private bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            bool[] taken = new bool[flowerbed.Length];
            Array.Fill(taken, false);

            if (flowerbed.Length == 1) // length One
            {
                if (flowerbed[0] == 1) // planted
                {
                    if (n == 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else // not planted
                {
                    return true;
                }
            }

            if (flowerbed[0] == 1) // Left Corner
            {
                taken[0] = true;
                taken[1] = true;
            }

            if (flowerbed[flowerbed.Length - 1] == 1) // Right Corner
            {
                taken[flowerbed.Length - 1] = true;
                taken[flowerbed.Length - 2] = true;
            }


            for (int i = 1; i < flowerbed.Length - 1; i++) // Middle
            {
                if (flowerbed[i] == 1)
                {
                    taken[i - 1] = true;
                    taken[i] = true;
                    taken[i + 1] = true;
                }
            }

            int count = 0;
            int possible = 0;
            for (int i = 0; i < flowerbed.Length; i++) // All check
            {
                if (!taken[i])
                {
                    count++;
                }
                else
                {
                    possible += (int)(Math.Ceiling(count / 2m));
                    count = 0;
                }
            }
            possible += (int)(Math.Ceiling(count / 2m));

            if (n <= possible)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
