public class Solution {
    public int SumIndicesWithKSetBits(IList<int> nums, int k) {
        IList<int> indices = new List<int>();
        int sum = 0;
        string binary;
        int count = 0;

        for (int i = 0; i < nums.Count; i++)
        {
            binary = Convert.ToString(i, 2);
            foreach (char bit in binary)
            {
                if (bit == '1')
                {
                    count++;
                }
            }

            if (count == k)
            {
                
                sum += nums[i];
            }
            count = 0;
        }
        
        return sum;
    }
}