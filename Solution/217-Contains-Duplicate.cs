public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        //int nums =new int [] nums;
        int nums_length = nums.Length;
        for (int i = 0; i < nums.Length-1; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] == nums[j]) {
                        return true;
                }
            }
        }
        return false;
    }
}