public class Solution {
    public void SortColors(int[] nums) {
        int n=nums.Length;
        int count_zero=0,count_one=0,count_two=0;
        for(int i=0;i<n;i++)
        {
            if(nums[i]==0)
            count_zero++;
            else if(nums[i]==1)
            count_one++;
            else if(nums[i]==2)
            count_two++;
        }

        for(int i =0;i<count_zero;i++)
        {
            nums[i]=0;
        }
        for(int i = count_zero;i<count_one+count_zero;i++)
        {
            nums[i]=1;
        }
        for(int i = count_zero+count_one;i<n;i++)
        {
            nums[i]=2;
        }
        
    }
}