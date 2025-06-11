namespace _697._Degree_of_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FindShortestSubArray(your_input);
        }

        static private int FindShortestSubArray(int[] nums)
        {
            if (nums.Length == 1 || nums.ToHashSet().Count == nums.Length) // If arrays has one or distinct elements
            {
                return 1;
            }

            Dictionary<int, int> frequencies = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!frequencies.ContainsKey(nums[i]))
                {
                    frequencies.Add(nums[i], 1);
                }
                else
                {
                    frequencies[nums[i]]++;
                }
            }

            int highest = frequencies.Max(f => f.Value);  // Most frequent number
            frequencies = new Dictionary<int, int>(frequencies.Where(x => x.Value == highest));

            int distance = 50001;
            int positionOne = 0, positionTwo = 0; // Double Pointers
            bool posOne = true, posTwo = true;

            for (int j = 0; j < frequencies.Count; j++)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (posOne && nums[i] == frequencies.Keys.ElementAt(j))
                    {
                        positionOne = i;
                        posOne = false;
                    }

                    if (posTwo && nums[nums.Length - 1 - i] == frequencies.Keys.ElementAt(j))
                    {
                        positionTwo = nums.Length - 1 - i;
                        posTwo = false;
                    }
                }
                posOne = true;
                posTwo = true;

                if ((positionTwo - positionOne + 1) < distance)
                {
                    distance = positionTwo - positionOne + 1;
                }
            }

            return distance;
        }
    }
}
