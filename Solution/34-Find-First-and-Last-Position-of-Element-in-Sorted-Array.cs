public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int start =-1,end=-1;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==target){
                if(start==-1){
                    start=i;
                }
                end=i;
            }
        }
        return new[] {start,end };
    }
}