public class Solution {
    public int AddDigits(int num) {
        return (num%9 == 0) ? ((num == 0) ? 0 : 9) : num%9;
    }
}