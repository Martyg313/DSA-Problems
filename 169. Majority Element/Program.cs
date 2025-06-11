namespace _169._Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MajorityElement(your_input);
        }

        static private int MajorityElement(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
            }
            int half = (nums.Length / 2);


            foreach (int element in set)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == element)
                    {
                        count++;
                    }
                }

                if (count > half) //Assumed their is always a majorirty number
                {
                    return element;
                }
            }
            return -1;
        }
    }
}
