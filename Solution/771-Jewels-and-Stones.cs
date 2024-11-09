public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count=0;
        foreach(var i in stones)
        {
            if(jewels.IndexOf(i)>-1)
                count++;
        }
        return count;

    }
}