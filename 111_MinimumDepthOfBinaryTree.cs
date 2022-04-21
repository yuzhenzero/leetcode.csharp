using System.Collections.Generic;
using System.Linq;

namespace leetcode.csharp
{
    public class MinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            int len = 1;
            queue.Enqueue(root);

            while (queue.Any())
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();

                    if (node.left == null && node.right == null)
                    {
                        return len;
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                len++;
            }

            return len;
        }
    }
}