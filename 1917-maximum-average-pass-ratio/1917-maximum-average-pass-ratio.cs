public class Solution {
    public double MaxAverageRatio(int[][] classes, int extraStudents)
    {
        var maxHeap = new PriorityQueue<(double Gain, int Passes, int Total), double>(Comparer<double>.Create((a, b) => b.CompareTo(a)));

        foreach (var singleClass in classes)
        {
            int passes = singleClass[0];
            int totalStudents = singleClass[1];
            double gain = CalculateGain(passes, totalStudents);
            maxHeap.Enqueue((gain, passes, totalStudents), gain);
        }

        while (extraStudents-- > 0)
        {
            var current = maxHeap.Dequeue();
            int passes = current.Passes;
            int totalStudents = current.Total;

            passes++;
            totalStudents++;

            double newGain = CalculateGain(passes, totalStudents);
            maxHeap.Enqueue((newGain, passes, totalStudents), newGain);
        }

        double totalPassRatio = 0;
        while (maxHeap.Count > 0)
        {
            var current = maxHeap.Dequeue();
            int passes = current.Passes;
            int totalStudents = current.Total;
            totalPassRatio += (double)passes / totalStudents;
        }

        return totalPassRatio / classes.Length;
    }

    private double CalculateGain(int passes, int totalStudents)
    {
        return ((double)(passes + 1) / (totalStudents + 1)) - ((double)passes / totalStudents);
    }
}