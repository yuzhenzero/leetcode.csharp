using System;

namespace leetcode.csharp
{
    public class Solution104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftMax = MaxDepth(root.left);
            int rightMax = MaxDepth(root.right);
            int res = Math.Max(leftMax, rightMax) + 1;
            return res;
        }
    }
}