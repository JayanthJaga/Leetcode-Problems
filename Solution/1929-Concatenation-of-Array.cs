public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int arr_length = nums.Length;

        int new_arr_length = 2*(nums.Length);
        int[] ans = new int[new_arr_length];
        for(int i=0;i<new_arr_length;i++)
        {
            if(i<arr_length)
                ans[i]=nums[i];
            else 
                ans[i]=nums[i-arr_length];
        }

        return ans;

    }
}