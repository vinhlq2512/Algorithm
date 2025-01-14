public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        int n = A.Length;
        int[] prefixCommonArray = new int[n];

        HashSet<int> elementsInA = new HashSet<int>();
        HashSet<int> elementsInB = new HashSet<int>();

        for (int currentIndex = 0; currentIndex < n; currentIndex++)
        {
            elementsInA.Add(A[currentIndex]);
            elementsInB.Add(B[currentIndex]);

            int commonCount = 0;

            foreach (int element in elementsInA)
            {
                if (elementsInB.Contains(element))
                {
                    commonCount++;
                }
            }

            prefixCommonArray[currentIndex] = commonCount;
        }

        return prefixCommonArray;
    }
}