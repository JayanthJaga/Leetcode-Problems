public class Solution {
    public int[] SearchRange(int[] nums, int target) {
            int first = SearchFirst(nums,target,true);
            int last = SearchFirst(nums,target,false);

            return new[] {first,last};


    }

    public static int SearchFirst(int[] nums,int target,bool first)
    {
        int left =0;
        int right = nums.Length-1;
        int result =-1;
        
        while(left<=right)
        {
            int mid = left+(right-left)/2;
            int midVal=nums[mid];
            if(midVal==target){
                result=mid;
                if(first==true)
                    right=mid-1;
                else
                    left=mid+1;
            }
            else if(midVal>target){
                right=mid-1;
            }
            else 
                left=mid+1;
        }

        return result;
    }
}