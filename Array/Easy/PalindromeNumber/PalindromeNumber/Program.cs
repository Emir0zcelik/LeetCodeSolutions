﻿public class Solution {
    public bool IsPalindrome(int x)
    {
        int temp = x;
        int reverse = 0;

        while (temp > 0)
        {
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }
        
        return x == reverse;
    }
}