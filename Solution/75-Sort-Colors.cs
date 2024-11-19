public class Solution {
    public void SortColors(int[] nums) {
        int large= 0;
        for(int i=0;i<nums.Length;i++)
        {
            for(int j=i+1;j<nums.Length;j++)
            {
                if(nums[i] > nums[j])
                {
                    large = nums[i];
                    nums[i] = nums[j];
                    nums[j] = large;
                }
            }
        
        }
    }
}