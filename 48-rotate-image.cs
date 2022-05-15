namespace leetcode.csharp
{
    public class Solution48
    {
        public void Rotate(int[][] matrix)
        {
            for (int i = 0; i < matrix[0].Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    (matrix[j][i], matrix[i][j]) = (matrix[i][j], matrix[j][i]);
                }
            }

            foreach (var row in matrix)
            {
                int i = 0, j = row.Length - 1;
                while (i < j)
                {
                    (row[i], row[j]) = (row[j], row[i]);
                    i++;
                    j--;
                }
            }
        }

        // static void Main(string[] args)
        // {
        //     int[][] matrix = new int[][] {
        //         new int[] { 1, 2, 3 },
        //         new int[] { 4, 5, 6 },
        //          new int[] { 7, 8, 9 }
        //          };
        //     foreach (int[] item in matrix)
        //     {
        //         System.Console.WriteLine(string.Join(',', item));
        //     }
        //     Solution48 s = new();
        //     s.Rotate(matrix);
        //     foreach (int[] item in matrix)
        //     {
        //         System.Console.WriteLine(string.Join(',', item));
        //     }
        // }
    }
}