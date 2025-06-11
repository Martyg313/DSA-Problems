namespace _136._Single_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingleNumber(your_input);
        }

        static private int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (nums[i * 2] != nums[i * 2 + 1])
                {
                    return nums[i * 2];
                }
            }
            return nums[nums.Length - 1];
        }
    }
}
