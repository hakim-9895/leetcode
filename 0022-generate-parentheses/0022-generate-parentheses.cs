public class Solution {
    public IList<string> GenerateParenthesis(int n) {
      

      var result = new  List<string>();
      backtrack(result,"",0,0,n);
        return result;

    }
     private  static void backtrack(List<string> result ,string current,    int open,int  close,int max){
        if(current.Length ==max*2){
            result.Add(current);
            return;
        }
        if(open<max){
            backtrack(result, current + "(", open + 1, close, max);
        }
        if(open>close){
             backtrack(result, current + ")", open, close + 1, max);
        }
     }

}