namespace _26._Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RemoveDuplicates(your_input);
        }

        static private int RemoveDuplicates(int[] nums)
        {
            int count = 0;

            int curr = nums[0];
            int mostFrequent = 0;
            int mostMostFrequent = 0;

            int temp1;
            int temp2;

            // check for one-array
            if (nums.Length == 1)
            {
                return 1;
            }

            // finds most frequent
            for (int i = 0; i < nums.Length; i++)
            {
                if (curr == nums[i])
                {
                    mostFrequent++;
                }
                else
                {
                    if (mostFrequent > mostMostFrequent)
                    {
                        mostMostFrequent = mostFrequent;
                    }

                    mostFrequent = 1;
                    curr = nums[i];
                }
            }

            // Swaps elements
            for (int x = 0; x < mostMostFrequent - 1; x++)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        //Console.WriteLine(String.Join(' ', nums));
                        temp1 = nums[nums.Length - 1];
                        nums[nums.Length - 1] = nums[i];

                        //Console.WriteLine(nums[i]);
                        for (int j = nums.Length - 2; j > i; j--)
                        {
                            //Console.WriteLine(true);
                            temp2 = nums[j];
                            nums[j] = temp1;
                            temp1 = temp2;

                        }
                        count++;
                    }
                }
            }


            int p = 0;
            while (nums[p + 1] > nums[p] && p < nums.Length - 2)
            {
                p++;
            }
            p++;
            if (Array.IndexOf(nums, nums.Max()) == nums.Length - 1)
            {
                p++;
            }

            return p;
        }
    }
}
