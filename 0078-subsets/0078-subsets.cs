public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> result = new  List<IList<int>>();
        List<int> current = new List<int>();
          backtrack(0,nums,current,result);

       return result;
    }
    private void backtrack(int index,int[] nums,List<int> current,List<IList<int>> result){

       result.Add(new List<int>(current));
       for(int i = index;i<nums.Length;i++){
        current.Add(nums[i]);
        backtrack(i+1,nums,current,result);
         current.RemoveAt(current.Count - 1);
        
       }
    }
}