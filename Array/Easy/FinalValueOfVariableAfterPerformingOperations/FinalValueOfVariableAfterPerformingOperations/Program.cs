public class Solution {
    public int FinalValueAfterOperations(string[] operations)
    {
        int sum = 0;

        for (int i = 0; i < operations.Length; i++)
        {
            if (operations[i].Contains("++"))
            {
                sum++;
            }
            if (operations[i].Contains("--"))
            {
                sum--;
            }
        }

        return sum;
    }
}