
namespace leetcode.csharp
{
    public class Solution26
    {
        public int RemoveDuplicates(int[] nums)
        {
            int slow = 1;
            int fast = 1;

            while (fast != nums.Length)
            {
                if (nums[fast] != nums[fast - 1])
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }

            return slow;
        }

        // static void Main(string[] args)
        // {
        //     Solution26 s = new Solution26();
        //     int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        //     int res = s.RemoveDuplicates(nums);
        //     System.Console.WriteLine(res);
        // }
    }
}