public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        int low =0;
        int high = nums.Length-1;
        while(low<=high)
        {
            int mid = (low+high)/2;
            int midVal=nums[mid];
            if(target==midVal)
                return mid;
            else if(midVal > target)
                {
                    high=mid-1;
                }
            else{
                low=mid+1;
            }
        }
        return low;
    }
}