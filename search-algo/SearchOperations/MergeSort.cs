
public class MergeSortExecutor
{

    public static void Execute()
    {
        int[] variable = [3, 4, 22, 5, 66, 7, 42, 6];
        var result = MergeSort(variable, 0, variable.Length - 1);
        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }
    }

    public static int[] MergeSort(int[] array, int left, int right)
    {

        if (left < right)
        {
            var middle = left + (right - left) / 2;

            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);

            MergeArraySorted(array, left, middle, right);

        }
        return array;
    }

    private static void MergeArraySorted(int[] array, int left, int middle, int right)
    {
        var leftLength = middle - left + 1;
        var rightLength = right - middle;

        var leftArray = new int[leftLength];
        var rightArray = new int[rightLength];

        int i, j;

        for (i = 0; i < leftLength; i++)
            leftArray[i] = array[left + i];
        for (j = 0; j < rightLength; j++)
            rightArray[j] = array[middle + 1 + j];

        i = 0; j = 0; int k = left;
        while (i < leftLength && j < rightLength)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k++] = leftArray[i++];
            }
            else
                array[k++] = rightArray[j++];
        }

        while (i < leftLength)
            array[k++] = leftArray[i++];
        while (j < rightLength)
            array[k++] = rightArray[j++];
    }
}