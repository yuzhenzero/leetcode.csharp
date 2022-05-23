namespace leetcode.csharp
{
    public class Solution226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            traverse(root);
            return root;
        }

        private void traverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            (root.right, root.left) = (root.left, root.right);

            traverse(root.left);
            traverse(root.right);
        }
    }
}