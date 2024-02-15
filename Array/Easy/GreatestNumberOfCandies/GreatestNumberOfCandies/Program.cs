public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> answer = new List<bool>();

        int max = 0;
        
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] > max)
            {
                max = candies[i];
            }
        }

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= max)
            {
                answer.Insert(i, true);
            }
            else
            {
                answer.Insert(i, false);
            }
        }

        return answer;
    }
}