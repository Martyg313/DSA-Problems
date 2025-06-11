namespace _100._Same_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsSameTree(your_input);
        }

        static private bool IsSameTree(TreeNode p, TreeNode q)
        {
            return SameTree(p, q);
        }

        static private bool SameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null || q == null)
            {
                return false;
            }
            if (p.val != q.val)
            {
                return false;
            }
            else
            {
                return SameTree(p.left, q.left) && SameTree(p.right, q.right);
            }
        }
    }
}
