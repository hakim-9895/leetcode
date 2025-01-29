public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> allStrings = new List<string>();

        for (int i = 1; i <= n; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                allStrings.Add("FizzBuzz");
            } else if (i % 3 == 0) {
                allStrings.Add("Fizz");
            } else if (i % 5 == 0) {
                allStrings.Add("Buzz");
            } else {
                allStrings.Add(i.ToString());
            }
        }

        return allStrings;
}
}
