namespace _217._Contains_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ContainsDuplicate(your_input);
        }

        static private bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> distinct = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (distinct.Contains(nums[i]))
                {
                    return true;
                }
                distinct.Add(nums[i]);
            }
            return false;
        }
    }
}
