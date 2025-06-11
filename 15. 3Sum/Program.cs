namespace _15._3Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ThreeSum(your_input);
        }

        static private IList<IList<int>> ThreeSum(int[] nums)
        {
            // **Copied Solution from submissions**

            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(nums);
            for (int s = 0; s < nums.Length - 2; s++)
            {
                int toFind = -1 * nums[s];
                int l = s + 1;
                int r = nums.Length - 1;

                //find 2 sum here
                while (l < r)
                {
                    int cur = nums[l] + nums[r];
                    if (cur > toFind)
                        r--;
                    else if (cur < toFind)
                        l++;
                    else
                    {
                        int left = nums[l];
                        int right = nums[r];
                        result.Add(new List<int>() { nums[s], left, right });
                        if (left == right)
                            break;

                        //if same number present as current left, skip them
                        while (l < r && nums[l] == left)
                            l++;

                        //if same number present as current right, skip them
                        while (l < r && nums[r] == right)
                            r--;
                    }
                }

                //if same number present as current start, skip them
                while (s < nums.Length - 2 && nums[s] == nums[s + 1])
                    s++;
            }

            return result;
        }
    }
}
