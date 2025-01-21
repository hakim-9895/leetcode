/**
 * @param {string} s
 * @return {string}
 */
var reverseWords = function(s) {
  let reversed=s.split(" ").map((m)=>m.split("").reverse().join("")).join(" ") 
  return reversed
};