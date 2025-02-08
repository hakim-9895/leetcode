public class Solution {
    public int[] TwoSum(int[] nums, int target) {
          Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i }; // Return indices of the two numbers
            }

            map[nums[i]] = i; // Store current number and its index
        }

        return new int[0]; 
    }
    }
