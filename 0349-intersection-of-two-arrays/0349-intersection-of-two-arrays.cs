public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> str =new HashSet<int>(nums1);
        HashSet<int> result =new HashSet<int>();
        foreach(var num in str){
            if(nums2.Contains(num)){
           result.Add(num);

            }
    
        }
        

     return result.ToArray();    
    }
}