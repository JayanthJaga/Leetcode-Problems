public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        string s1=strs[0];
        string s2=strs[strs.Length-1];
        int i=0;
        while(i<s1.Length && i<s2.Length)
        {
            if(s1[i]==s2[i])
                i++;
            else
                break;
        }
        return s1.Substring(0,i);
    }
}