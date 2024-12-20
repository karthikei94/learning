namespace search_algo;

public partial class Program
{

    /// <summary>
    /// *** TERNARY SEARCH ***
    /// ? When can it be used => Works on sorted arrays
    /// ! Complexity => O(log n)
    /// </summary>
    public static void TernarySearchOperation()
    {
        int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        var target = 6;
        Console.WriteLine(TernarySearch(arr, 0, arr.Length - 1, target));
    }

    public static int TernarySearch(int[] arr, int left, int right, int target)
    {
        if (right >= left)
        {
            int mid1 = left + (right - left) / 3;
            int mid2 = right - (right - left) / 3;

            if (arr[mid1] == target) return mid1;
            if (arr[mid2] == target) return mid2;

            if (target < arr[mid1])
                return TernarySearch(arr, left, mid1 - 1, target);
            if (target > arr[mid2])
                return TernarySearch(arr, mid2 + 1, right, target);
            else
                return TernarySearch(arr, mid1 + 1, mid2 - 1, target);
        }
        return -1;

        // ! logic as per binary is below
        // var mid = left + (right - left) / 2;
        // while (left <= right)
        // {
        //     if (arr[mid] == target) return mid;
        //     else if (arr[mid] < target) left = mid + 1;
        //     else right = mid - 1;
        // }
        // return -1;
    }
}