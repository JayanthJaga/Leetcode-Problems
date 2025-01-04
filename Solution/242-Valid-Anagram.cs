public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        int[] counter = new int[26];

        for(int i=0;i<s.Length;i++)
        {
            counter[s[i]-'a']++;
            counter[t[i]-'a']--;
        }
        foreach(int i in counter)
        if(i!=0){
            return false;
        }
        return true;




        // foreach(char i in s)
        // {
        //     if((!(t.Contains(i))) || (s.Length != t.Length))
        //         return false;
        // }
        // return true;
        
    }
}