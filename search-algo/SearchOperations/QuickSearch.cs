// ! QUICK SORT
// Variation	| Time Complexity	| Auxiliary Space
// Best Case	| O(n log n)	    | O(log n)
// Average Case	| O(n log n)	    | O(log n)
// Worst Case	| O(n^2)	        | O(n)
public class QuickSearchOperation
{

    public static void Execute()
    {
        int[] value = [4, 55, 2, 44, 7, 8];
        var result  = QuickSort(value, 0, value.Length - 1);
        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }

    }
    public static int[] QuickSort(int[] array, int left, int right)
    {
        var pivot = array[left];
        var i = left;
        var j = right;

        while (i <= j)
        {
            if (array[i] < pivot)
            {
                i++;
            }
            while (array[j] > pivot)
                j--;
            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (left < j)
            QuickSort(array, left, j);
        if (i < right)
            QuickSort(array, i, right);
        return array;
    }
}
