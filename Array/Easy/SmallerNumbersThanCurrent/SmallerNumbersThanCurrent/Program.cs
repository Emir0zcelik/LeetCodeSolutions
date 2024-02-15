public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] answer = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    if (nums[i] > nums[j])
                    {
                        answer[i]++;
                    }
                }
            }
        }

        return answer;
    }
}