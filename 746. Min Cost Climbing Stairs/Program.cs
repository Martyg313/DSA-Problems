namespace _746._Min_Cost_Climbing_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MinCostClimbingStairs(your_input);
        }

        static private int MinCostClimbingStairs(int[] cost)
        {
            List<int> minCost = new List<int>() { 0, 0 };

            for (int i = 2; i < cost.Length + 1; i++)
            {
                int nextCost = Math.Min(minCost[i - 2] + cost[i - 2], minCost[i - 1] + cost[i - 1]);
                minCost.Add(nextCost);
            }

            return minCost[minCost.Count - 1];
        }
    }
}
