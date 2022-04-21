using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode.csharp
{
    public class PartitionK
    {
        Dictionary<int, bool> map = new();

        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            if (k > nums.Length)
            {
                return false;
            }

            if (nums.Sum() % k != 0)
            {
                return false;
            }

            int target = nums.Sum() / k;
            int used = 0;
            bool res = backtrack(k, 0, nums, 0, used, target);

            return res;
        }

        private bool backtrack(int k, int bucket, int[] nums, int start, int used, int target)
        {
            if (k == 0)
            {
                return true;
            }

            if (bucket == target)
            {
                var res = backtrack(k - 1, 0, nums, 0, used, target);
                map[used] = res;
                return res;
            }

            if (map.ContainsKey(used))
            {
                return map[used];
            }

            for (int i = start; i < nums.Length; i++)
            {
                if (((used >> i) & 1) == 1)
                {
                    continue;
                }

                if (bucket + nums[i] > target)
                {
                    continue;
                }

                used |= 1 << i;
                bucket += nums[i];

                if (backtrack(k, bucket, nums, start + 1, used, target))
                {
                    return true;
                }

                used ^= 1 << i;
                bucket -= nums[i];
            }

            return false;
        }

        public static void Main(string[] args)
        {
            PartitionK partitionK = new PartitionK();
            int[] nums = {4, 3, 2, 3, 5, 2, 1};
            int k = 4;
            var res = partitionK.CanPartitionKSubsets(nums, k);
            Console.WriteLine(res);
        }
    }
}