public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max_sum =0;
         int count =0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==1)
                count++;
            else 
                count=0;
            max_sum = Math.Max(count,max_sum);
        }
        Console.WriteLine(max_sum);
        Console.WriteLine(count);
        return max_sum;

    }
}