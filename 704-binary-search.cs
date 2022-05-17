

namespace leetcode.csharp
{
    public class Solution704
    {
        public int Search(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {

                int mid = left + (right - left) / 2;
                if (target == nums[mid])
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else if (target > nums[mid])
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

        // static void Main(string[] args)
        // {
        //     int[] nums = { -1, 0, 3, 5, 9, 12 };
        //     int target = 9;
        //     Solution704 s = new();
        //     System.Console.WriteLine(s.Search(nums, target));
        // }
    }
}