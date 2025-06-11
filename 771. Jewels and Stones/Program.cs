namespace _771._Jewels_and_Stones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NumJewelsInStones(your_input);
        }

        static private int NumJewelsInStones(string jewels, string stones)
        {
            int numOfJewels = 0;
            for (int i = 0; i < jewels.Length; i++)
            {
                numOfJewels += stones.Count(x => x.Equals(jewels[i]));
            }
            return numOfJewels;
        }
    }
}
