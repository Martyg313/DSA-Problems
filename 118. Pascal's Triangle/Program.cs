namespace _118._Pascal_s_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generate(your_input);
        }

        static private IList<IList<int>> Generate(int numRows)
        {
            if (numRows == 1)
            {
                IList<IList<int>> numscase1 = new List<IList<int>>();
                numscase1.Add(new List<int>());
                numscase1[0].Add(1);
                return numscase1;
            }
            else if (numRows == 2)
            {
                IList<IList<int>> numscase2 = new List<IList<int>>();
                numscase2.Add(new List<int>());
                numscase2.Add(new List<int>());
                numscase2[0].Add(1);
                numscase2[1].Add(1);
                numscase2[1].Add(1);
                return numscase2;
            }

            // Setup
            IList<IList<int>> nums = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                nums.Add(new List<int>());
            }

            nums[0].Add(1);
            nums[1].Add(1);
            nums[1].Add(1);

            int b = 1;
            int preceding = 0;
            int proceding = 1;

            // Pascal's Triangle
            for (int i = 2; i < numRows; i++)
            {
                nums[i].Add(1);
                for (int x = 0; x < b; x++)
                {
                    nums[i].Add(nums[i - 1][preceding] + nums[i - 1][proceding]);
                    preceding++;
                    proceding++;
                }
                preceding = 0;
                proceding = 1;
                nums[i].Add(1);
                b++;
            }

            return nums;
        }
    }
}
