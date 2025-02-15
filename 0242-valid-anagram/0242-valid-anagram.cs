public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length!=t.Length) return false;
        int[] lettercount = new int[26];
     for ( int i=0 ; i<s.Length ; i++){

       lettercount[s[i]-'a']++;
       lettercount[t[i]-'a']--;
        }
        foreach(var count in lettercount){
            if(count!=0) return false;
     }
            return true;
     }   
    }
