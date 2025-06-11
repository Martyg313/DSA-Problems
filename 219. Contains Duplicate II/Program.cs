namespace _219._Contains_Duplicate_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ContainsNearbyDuplicate(your_input);
        }

        static private bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> numberPairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!numberPairs.ContainsKey(nums[i]))
                {
                    numberPairs.Add(nums[i], i);
                }
                else
                {
                    if (Math.Abs(numberPairs[nums[i]] - i) <= k)
                    {
                        return true;
                    }

                    numberPairs[nums[i]] = i;
                }
            }
            return false;
        }
    }
}
