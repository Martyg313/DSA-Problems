namespace _144._Binary_Tree_Preorder_Traversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PreorderTraversal(your_input);
        }

        List<int> preOrder = new List<int>();

        public IList<int> PreorderTraversal(TreeNode root)
        {
            //check for empty node
            if (root == null)
            {
                return preOrder;
            }

            // Action -> recurse left -> recurse right
            preOrder.Add(root.val);
            if (root.left != null)
                PreorderTraversal(root.left);
            if (root.right != null)
                PreorderTraversal(root.right);

            return preOrder;
        }
    }
}
