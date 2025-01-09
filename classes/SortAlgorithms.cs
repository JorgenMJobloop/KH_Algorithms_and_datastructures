public class SortAlgorithms
{
    /// <summary>
    /// bubble sort is not generally considered a fast algorithm
    /// Steps:
    ///     - assign a variable to hold the length of n
    ///     - use nested for-loops to iterate through the array, "split" the array up, and then sort the array
    /// </summary>
    /// <param name="arr">The array to sort!</param>
    public void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // if the index of [j] in the array
                    // is greater than j+1
                    // we swap the values of [j] & [j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    /// <summary>
    /// steps:
    /// 1: check if low is less than high
    /// 2: if 1 is true, we create a pivot variable -> int pivot = arr[high] & an iterator -> int i
    /// 3: call the recusirve method
    /// </summary>
    /// <param name="arr">integer array</param>
    /// <param name="low">int low</param>
    /// <param name="high">int high</param>
    public void Quicksort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Recursion(arr, low, high);
            // call Quicksort recursively
            Quicksort(arr, low, pivot - 1);
            Quicksort(arr, pivot + 1, high);
        }
    }

    public int Recursion(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            // first swap
            if (arr[j] < pivot)
            {
                // increment i
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        // second swap
        int swapTemp = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swapTemp;
        return i + 1;
    }
}