public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int left = 0;
        int right = k - 1;
        double result = double.MinValue;
        while(right < nums.Length)
        {
            double curr = 0;
            for(int i = left; i < right + 1; i ++)
            {
                curr += nums[i];
            }
            curr = curr / k;
            result = Math.Max(result, curr);
            left ++;
            right ++;
        }
        return result;
    }
}
