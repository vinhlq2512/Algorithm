public class Solution {
    public bool CheckIfExist(int[] arr) {
        int n = arr.Length;
        HashSet<int> check = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            if (check.Contains(arr[i] * 2))
            {
                return true;
            }
            if((arr[i] % 2 == 0 && check.Contains(arr[i] / 2))){
                return true;
            }
            check.Add(arr[i]);
        }
        return false;
    }
}