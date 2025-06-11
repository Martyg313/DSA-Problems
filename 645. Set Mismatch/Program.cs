namespace _645._Set_Mismatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FindErrorNums(your_input);
        }

        static private int[] FindErrorNums(int[] nums)
        {
            int[] targ = new int[2];
            Array.Sort(nums);
            bool miss = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1]) // Duplicant number
                {
                    targ[0] = nums[i];
                }

                if (!miss) // Missing number
                {
                    if (nums.Length == 2)
                    {
                        if (nums[i] == 1)
                        {
                            targ[1] = nums[i] + 1;
                        }
                        else if (nums[i] == 2)
                        {
                            targ[1] = nums[i] - 1;
                        }
                        miss = true;
                    }
                    else
                    {
                        if (nums[i + 1] - nums[i] == 2)
                        {
                            targ[1] = nums[i] + 1;
                            miss = true;
                        }
                        else
                        {
                            if (nums[0] == nums[1])
                            {
                                targ[1] = nums[i] - 1;
                            }
                        }
                    }
                }
            }

            if (!miss)
            {
                if (nums[0] - 1 != 0)
                {
                    targ[1] = nums[0] - 1;
                }
                else
                {
                    targ[1] = nums[nums.Length - 1] + 1;
                }
            }

            return targ;
        }
    }
}
