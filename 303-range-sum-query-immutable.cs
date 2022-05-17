namespace leetcode.csharp
{
    public class NumArray
    {
        private int[] preSum;

        public NumArray(int[] nums)
        {
            preSum = new int[nums.Length + 1];
            preSum[0] = 0;
            for (int i = 1; i < preSum.Length; i++)
            {
                preSum[i] = preSum[i - 1] + nums[i - 1];
            }
        }

        public int SumRange(int left, int right)
        {
            return preSum[right + 1] - preSum[left];
        }

        // static void Main(string[] args)
        // {
        //     int[] nums = {-2, 0, 3, -5, 2, -1};
        //     NumArray numArray = new(nums);
        //     System.Console.WriteLine(numArray.SumRange(0,2));
        //     System.Console.WriteLine(numArray.SumRange(2,5));
        //     System.Console.WriteLine(numArray.SumRange(0,5));

        // }
    }

}