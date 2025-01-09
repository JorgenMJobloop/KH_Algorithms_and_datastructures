public class SearchAlgorithms
{
    public int LinearSearch(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    public int BinarySearchImplementation(int[] arr, int x)
    {
        int leftSide = 0;
        int rightSide = arr.Length - 1;
        while (leftSide <= rightSide)
        {
            int middle = leftSide + (rightSide - leftSide) / 2;
            if (arr[middle] == x)
            {
                return middle;
            }
            if (arr[middle] < x)
            {
                leftSide = middle + 1;
            }
            else
            {
                rightSide = middle - 1;
            }
        }
        return -1;
    }
}