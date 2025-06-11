namespace _561._Array_Partition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayPairSum(your_input);
        }

        static private int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int total = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                total += nums[i];
            }
            return total;
        }
    }
}
