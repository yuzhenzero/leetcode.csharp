using System;
using System.Collections.Generic;

namespace leetcode.csharp
{
    public class Permutations
    {
        private IList<IList<int>> res = new List<IList<int>>();

        public IList<IList<int>> Permute(int[] nums)
        {
            int n = nums.Length;
            bool[] visited = new bool[n];
            IList<int> path = new List<int>();

            backtrack(nums, path, visited);
            return res;
        }

        private void backtrack(int[] nums, IList<int> path, bool[] visited)
        {
            if (path.Count == nums.Length)
            {
                res.Add(new List<int>(path));
                return;
            }

            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                visited[i] = true;
                path.Add(nums[i]);
                backtrack(nums, path, visited);
                path.RemoveAt(path.Count - 1);
                visited[i] = false;
            }
        }

        // public static void Main(string[] args)
        // {
        //     Permutations p = new Permutations();
        //
        //     int[] test = {1, 2, 3};
        //
        //     IList<IList<int>> output = p.Permute(test);
        //     foreach (var list in output)
        //     {
        //         Console.WriteLine(string.Join(',', list));
        //     }
        //
        //     
        //
        // }
    }
}