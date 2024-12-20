namespace search_algo;
public partial class Program{
    private static void JumpSearchOperation()
    {
        var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var target = 5;
        var t = JumpSearch(arr, target);
        Console.WriteLine(t);
    }

    public static int JumpSearch(int[] arr, int target)
    {
        int n = arr.Length;
        int step = (int)Math.Floor(Math.Sqrt(n));
        int prev = 0;
        Console.WriteLine("steps: " + step);
        Console.WriteLine("Min: " + Math.Min(step, n));
        while (arr[Math.Min(step, n) - 1] < target)
        {
            Console.WriteLine("RUN first");
            prev = step;
            step += (int)Math.Floor(Math.Sqrt(n));
            if (prev >= n) return -1;
        }

        while (arr[prev] > target)
        {
            Console.WriteLine("RUN second");
            prev++;
            if (prev == Math.Min(step, n))
                return -1;
        }

        return arr[prev] == target ? prev : -1;
    }
}