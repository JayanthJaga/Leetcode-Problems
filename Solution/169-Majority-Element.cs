public class Solution {
    public int MajorityElement(int[] nums) {
        int count =0,ret=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(count ==0)
                ret=nums[i];
            if(nums[i]!=ret)
                count--;
            else 
                count++;
        }
        return ret;
    }
}