namespace _506._Relative_Ranks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FindRelativeRanks(your_input);
        }

        static private string[] FindRelativeRanks(int[] score)
        {
            string[] wordScores = new string[score.Length];

            int reservedPlaces = 1;
            for (int j = 0; j < score.Length; j++)
            {
                int newPlace = Array.IndexOf(score, score.Max());

                if (reservedPlaces == 1)
                {
                    wordScores[newPlace] = "Gold Medal";
                    reservedPlaces++;
                }
                else if (reservedPlaces == 2)
                {
                    wordScores[newPlace] = "Silver Medal";
                    reservedPlaces++;
                }
                else if (reservedPlaces == 3)
                {
                    wordScores[newPlace] = "Bronze Medal";
                    reservedPlaces++;
                }
                else
                {
                    wordScores[newPlace] = reservedPlaces.ToString();
                    reservedPlaces++;
                }

                score[newPlace] = -1; // eliminates spot
            }

            return wordScores;
        }
    }
}
