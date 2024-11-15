public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count=0;
        for(int i=0;i<nums.Length;i++)
        {
            int sum=nums[i];
            if(sum==k)
                count++;
            for(int j=i+1;j<nums.Length;j++)
            {
                sum+=nums[j];
                if(sum==k)
                {
                    count++;
                }
            }
        } 
        Console.WriteLine(count);  
        return count;     
    }
}