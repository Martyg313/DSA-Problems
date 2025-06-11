namespace _35._Search_Insert_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SearchInsert(your_input);
        }

        static private int SearchInsert(int[] nums, int target)
        {
            // Corner Cases
            if (target > nums[nums.Length - 1])
            {
                return nums.Length;
            }
            else if (target < nums[0])
            {
                return 0;
            }

            // BinSearch
            int start = 0, end = nums.Length, middle = 0;
            while (start < end)
            {
                middle = (start + end) / 2;

                // If middle is target
                if (target == nums[middle])
                {
                    return middle;
                }

                if (target > nums[middle]) // If target is greater than middle
                {
                    if (end - start == 1)
                    {
                        return (start + 1);
                    }
                    start = middle;
                }
                else // If target is less than middle
                {
                    if (end - start == 1)
                    {
                        return (start - 1);
                    }
                    end = middle;
                }
            }
            return middle;
        }
    }
}
