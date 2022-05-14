namespace leetcode.csharp
{
    public class Solution1109
    {
        public int[] CorpFlightBookings(int[][] bookings, int n)
        {
            int[] res = new int[n];
            int[] diff = new int[n];

            foreach (var booking in bookings)
            {
                int start = booking[0] - 1;
                int end = booking[1] - 1;
                int inc = booking[2];
                diff[start] += inc;
                if (end + 1 < res.Length)
                {
                    diff[end + 1] -= inc;
                }

            }

            res[0] = diff[0];

            for (int i = 1; i < diff.Length; i++)
            {
                res[i] = res[i - 1] + diff[i];
            }

            return res;
        }
        static void Main(string[] args)
        {
            Solution1109 s = new Solution1109();
            int[][] bookings = new int[][] { new int[] { 1, 2, 10 }, new int[] { 2, 3, 20 }, new int[] { 2, 5, 25 } };
            int[] res = s.CorpFlightBookings(bookings, 5);
            foreach (var i in res)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}