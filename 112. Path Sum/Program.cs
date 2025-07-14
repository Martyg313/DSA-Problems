namespace _112._Path_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HasPathSum(your_input);
        }

        int sum = 0;
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            // Null check
            if (root == null)
                return false;

            // Action
            sum += root.val;
            if (sum == targetSum && root.left == null && root.right == null)
                return true;

            // Recursion
            if (root.left != null)
            {
                if (HasPathSum(root.left, targetSum))
                    return true;
            }
            if (root.right != null)
            {
                if (HasPathSum(root.right, targetSum))
                    return true;
            }

            // Backtrack to prior node value
            sum -= root.val;
            return false;
        }
    }
}
