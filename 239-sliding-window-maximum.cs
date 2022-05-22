using System.Collections.Generic;
using System.Linq;

namespace leetcode.csharp
{
    public class Solution239
    {
        class MonotonicQueue
        {
            private LinkedList<int> maxq = new();
            public void push(int n)
            {
                while (maxq.Count > 0 && maxq.Last.Value < n)
                {
                    maxq.RemoveLast();
                }
                maxq.AddLast(n);
            }
            public int max()
            {
                return maxq.First.Value;

            }
            public void pop(int n)
            {
                if (maxq.First.Value == n)
                {
                    maxq.RemoveFirst();
                }
            }
        }

        MonotonicQueue window = new();
        List<int> res = new();
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < k - 1)
                {
                    window.push(nums[i]);
                }
                else
                {
                    window.push(nums[i]);
                    res.Add(window.max());
                    window.pop(nums[i - k + 1]);
                }
            }

            return res.ToArray();

        }

        // static void Main(string[] args)
        // {
        //     Solution239 s = new();
        //     int[] nums = {1,3,-1,-3,5,3,6,7};
        //     int k = 3;
        //     int[] res = s.MaxSlidingWindow(nums, k);
        //     foreach (var item in res)
        //     {
        //         System.Console.WriteLine(item);
        //     }
        // }
    }
}