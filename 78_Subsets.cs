using System;
using System.Collections.Generic;

namespace leetcode.csharp
{
    public class Subset
    {
        private IList<IList<int>> res = new List<IList<int>>();
        private LinkedList<int> path = new LinkedList<int>();

        public IList<IList<int>> Subsets(int[] nums)
        {
            backtrack(nums, 0);

            return res;
        }

        private void backtrack(int[] nums, int start)
        {
            res.Add(new List<int>(path));

            for (int i = start; i < nums.Length; i++)
            {
                path.AddLast(nums[i]);
                backtrack(nums, i + 1);
                path.RemoveLast();
            }
        }

        public static void Main(string[] args)
        {
            Subset subset = new Subset();
            int[] nums = {1, 2, 3};
            var res = subset.Subsets(nums);
            Console.WriteLine(nums);
            foreach (var list in res)
            {
                Console.WriteLine(string.Join(",", list));
            }
        }
    }
}