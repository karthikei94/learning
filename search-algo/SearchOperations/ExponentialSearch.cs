namespace search_algo;

public partial class Program
{

    /// <summary>
    /// ? When can it be used => When unbounded and infinite list
    /// ! Complexity => O(lon n)
    /// </summary>
    public static void ExponenetialSearchOperation()
    {
        int[] arr = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
        var target = 7;
        Console.WriteLine(ExponentialSearch(arr, target));
    }

    private static int ExponentialSearch(int[] arr, int target)
    {
        if (arr[0] == target) return 0;

        int i = 1;
        while (i < arr.Length && arr[i] <= target)
            i *= 2;
        return BinarySearch(arr, i / 2, Math.Min(i, arr.Length - 1), target);
    }

    public static int BinarySearch(int[] arr, int left, int right, int target)
    {
        var mid = left + (right - left) / 2;
        while (left <= right)
        {
            if (arr[mid] == target) return mid;
            else if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }
}