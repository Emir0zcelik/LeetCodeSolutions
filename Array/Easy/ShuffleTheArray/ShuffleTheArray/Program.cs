public class Solution {
    public int[] Shuffle(int[] nums, int n)
    {
        int[] ans = new int[nums.Length];
        int j = 0;
        int k = n;
        for (int i = 0; i < 2 * n; i++)
        {
            ans[i] = (i % 2 == 0) ? nums[j++] : nums[k++];
        }

        return ans;
    }
}