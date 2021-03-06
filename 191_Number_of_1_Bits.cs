public class Solution {
    public int HammingWeight(uint n) {
        var count = 0;
        while(n!=0)
        {
            count += 1;
            n = n&(n-1);
        }
        
        return count;
    }
}