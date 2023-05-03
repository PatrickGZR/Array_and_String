public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int n = nums.Length;
        int[] tempnums = new int[n + 1];
        for(int i = 1; i < n + 1; i ++)
        {
            tempnums[i] = tempnums[i - 1] + nums[i - 1];
        }
        int result = tempnums[k];
        for(int i = 0; i < n - k + 1; i++)
        {
            result = Math.Max(result, tempnums[k+i] - tempnums[i]);
        }
        return result * 1.0 / k;
    }
}
