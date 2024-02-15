public class Solution {
    public int[] RunningSum(int[] nums)
    {
        int temp = 0;
        int[] answer = new int[nums.Length];
        int i = 0;
        
        foreach (var num in nums)
        {
            temp += num;
            answer[i++] = temp;
        }

        return answer;
    }
}