namespace _1005._Maximize_Sum_Of_Array_After_K_Negations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static private int LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);
            int negatives = nums.Count(x => x < 0); // # of negatives
            Console.WriteLine(negatives);

            // Makes the most optimal array
            int i = 0;
            while (negatives > 0 && k > 0)
            {
                nums[i] = -nums[i];
                i++;
                negatives--;
                k--;
            }
            if (k % 2 != 0)
            {
                int ind = Array.FindIndex(nums, x => x.Equals(nums.Min()));
                nums[ind] = -nums[ind];
                Console.WriteLine(true);
            }

            // Calculates sum
            int count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                count += nums[j];
            }

            return count;
        }
    }
}
