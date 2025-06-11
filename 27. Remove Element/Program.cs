namespace _27._Remove_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RemoveElement(your_input);
        }

        static private int RemoveElement(int[] nums, int val)
        {
            // Re-ordering non "val" elements
            int realIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[realIndex] = nums[i];
                    realIndex++;
                }
            }

            return realIndex;
        }
    }
}
