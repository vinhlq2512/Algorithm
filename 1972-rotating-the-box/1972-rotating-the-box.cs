public class Solution {
    public char[][] RotateTheBox(char[][] box)
    {
        int m = box.Length;
        int n = box[0].Length;
        char[][] result = new char[n][];

        for (int i = 0; i < n; i++)
        {
            result[i] = new char[m];
            for (int j = 0; j < m; j++)
            {
                result[i][j] = box[j][i];
            }
        }

        for (int i = 0; i < n; i++)
        {
            int left = 0, right = m - 1;
            while (left < right)
            {
                char temp = result[i][left];
                result[i][left] = result[i][right];
                result[i][right] = temp;
                left++;
                right--;
            }
        }

        for (int j = 0; j < m; j++)
        {
            int lowestRowWithEmptyCell = n - 1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (result[i][j] == '#')
                {
                    result[i][j] = '.';
                    result[lowestRowWithEmptyCell][j] = '#';
                    lowestRowWithEmptyCell--;
                }
                if (result[i][j] == '*')
                {
                    lowestRowWithEmptyCell = i - 1;
                }
            }
        }

        return result;
    }
}