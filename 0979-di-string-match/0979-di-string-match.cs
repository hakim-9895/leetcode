public class Solution {
    public int[] DiStringMatch(string s) {
        int n = s.Length;
        int[] perm = new int[n + 1]; 
        int left = 0;  
        int right = n; 
        
        
        for (int i = 0; i < n; i++) {
            if (s[i] == 'I') {
                perm[i] = left++; 
            } else {
                perm[i] = right--; 
            }
        }
        
        
        perm[n] = left; 
        
        return perm;
    }
}
