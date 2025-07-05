namespace _94._Binary_Tree_Inorder_Traversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InorderTraversal(your_input);
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            // List Creation
            List<int> output = new List<int>();

            return InorderTraversalRecursive(root, output);
        }

        public IList<int> InorderTraversalRecursive(TreeNode root, List<int> output)
        {
            if (root == null)
            {
                // Do nothing
            }
            else
            {
                if (root.left != null)
                {
                    InorderTraversalRecursive(root.left, output);
                }

                output.Add(root.val);

                if (root.right != null)
                {
                    InorderTraversalRecursive(root.right, output);
                }
            }

            return output;
        }
    }
}
