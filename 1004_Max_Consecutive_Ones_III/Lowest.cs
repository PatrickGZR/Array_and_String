public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int n = nums.Length;
        int result = Int32.MinValue;
        for(int i = 0; i < nums.Length; i ++)
        {
            int j = i;
            int sum = 0;
            int remaink = k;
            while(j < nums.Length)
            {
                if(nums[j] == 0 && remaink != 0)
                {
                    sum = sum + 1;
                    remaink = remaink - 1;
                }
                else if(nums[j] == 1)
                {
                    sum = sum + 1;
                }
                else
                {
                    break;
                }
                j ++;
            }
            result = Math.Max(result, sum);
        }
        return result;
    }
}
