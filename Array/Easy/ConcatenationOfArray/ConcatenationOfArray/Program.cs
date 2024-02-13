public class Solution {
    public int[] GetConcatenation(int[] nums)
    {
        int[] ans = new int[nums.Length * 2];
        int j = 0;
        for (int i = 0; i < ans.Length; i++)
        {
            if (i < nums.Length)
            {
                ans[i] = nums[i];
            }
            else
            {
                ans[i] = ans[j++];
            }
        }

        return ans;
    }
}