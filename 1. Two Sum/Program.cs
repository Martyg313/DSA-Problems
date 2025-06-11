namespace _1._Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TwoSum(your_input);
        }

        static private int[] TwoSum(int[] nums, int target)
        {
            int[] pair = new int[2];
            for (int j = 0; j < nums.Length; j++)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[j] + nums[i] == target && i != j)
                    {
                        pair[0] = j;
                        pair[1] = i;
                        return pair; // finishes faster
                    }
                }
            }
            return pair;
        }
    }
}
