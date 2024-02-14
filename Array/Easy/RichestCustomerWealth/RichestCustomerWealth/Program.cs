public class Solution {
    public int MaximumWealth(int[][] accounts)
    {
        int ans = 0;

        int[] sum = new int[accounts.GetLength(0)];

        for (int i = 0; i < accounts.Length; i++)
        {
            sum[i] = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum[i] += accounts[i][j];
            }
        }

        for (int i = 0; i < sum.Length; i++)
        {
            if (sum[i] >= ans)
            {
                ans = sum[i];
            }
        }
        return ans;
    }
}