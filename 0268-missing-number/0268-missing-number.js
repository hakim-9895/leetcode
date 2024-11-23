/**
 * @param {number[]} nums
 * @return {number}
 */
var missingNumber = function(nums) {
    let sorted=nums.sort((a,b)=>a-b)
    for(let i=0;i<=nums.length;i++){
        if(nums[i]!==i){
            return i
        }
        if(nums.length==0){
            return 0
        }
        
    }
   
};