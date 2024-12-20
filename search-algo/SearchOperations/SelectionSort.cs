// ! SELECTION SORT

// 1. maintains minimum value
// 2. If the current value is LESS than MINIMUM then SWAP.
// 3. this process continues until it's sorted.

// Variation	| Time Complexity	| Auxiliary Space
// Best Case	| O(n^2)	        | O(log n)
// Average Case	| O(n^2)	        | O(log n)
// Worst Case	| O(n^2)	        | O(n)

public class SelectionSortExecutioner
{
    public static void Execute()
    {
        var result = SelectionSort([33, 44, 11, 55, 77, 32, 23, 78]);
        foreach (var item in result)
        {
            System.Console.WriteLine(item);
        }
    }

    public static int[] SelectionSort(int[] array)
    {

        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.WriteLine($"Iteration: {i}");
            var minimum = i;
            System.Console.WriteLine();
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minimum])
                {
                System.Console.WriteLine($"Went in: {j}");
                    minimum = j;
                }
            }
            var temp = array[minimum];
            array[minimum] = array[i];
            array[i] = temp;
        }
        return array;
    }
}

