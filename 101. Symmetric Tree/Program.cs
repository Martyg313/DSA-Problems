namespace _101._Symmetric_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsSymmetric(your_input);
        }

        private bool DFS(TreeNode leftRoot, TreeNode rightRoot)
        {
            if (leftRoot == null && rightRoot == null)
            {
                return true;
            }
            if (leftRoot == null || rightRoot == null)
            {
                return false;
            }
            if (leftRoot.val != rightRoot.val)
            {
                return false;
            }

            bool isCheckOne = DFS(rightRoot.right, leftRoot.left);
            bool isCheckTwo = DFS(rightRoot.left, leftRoot.right);
            return isCheckOne && isCheckTwo ? true : false;
        }
        public bool IsSymmetric(TreeNode root)
        {
            return DFS(root.left, root.right);
        }
    }
}
