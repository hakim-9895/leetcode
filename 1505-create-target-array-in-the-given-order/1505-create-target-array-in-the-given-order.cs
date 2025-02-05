public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        List<int> array= new List<int>();
        for (int i =0;i<nums.Length;i++){
            array.Insert(index[i],nums[i]);
        }
        return array.ToArray();
    }
}