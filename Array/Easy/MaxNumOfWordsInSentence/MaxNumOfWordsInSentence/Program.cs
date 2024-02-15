public class Solution
{
    public int MostWordsFound(string[] sentences)
    {
        int max = 0;

        foreach (string sentence in sentences)
        {
            int count = sentence.Split(' ').Length;
            max = Math.Max(max, count);
        }

        return max;
    }
}