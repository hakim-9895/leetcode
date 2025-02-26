public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
     List<IList<int>> result = new List<IList<int>>();
        Backtrack(nums, 0, result);
        return result;
         
    }
     private void Backtrack(int[] nums, int start, List<IList<int>> result) {
        if (start == nums.Length) {
            result.Add(new List<int>(nums)); 
            return;
        }

        for (int i = start; i < nums.Length; i++) {
            Swap(nums, start, i);
            Backtrack(nums, start + 1, result);
            Swap(nums, start, i); 
        }
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

}