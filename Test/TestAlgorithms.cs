public class TestAlgorithms
{
    SortAlgorithms sortAlgorithms = new SortAlgorithms();
    SearchAlgorithms searchAlgorithms = new SearchAlgorithms();
    [Fact]
    public void TestBubbleSort()
    {
        int[] arrayToSort = { 2, 3, 1, 4, 7, 5, 6 };
        int[] sorted = { 1, 2, 3, 4, 5, 6, 7 };
        sortAlgorithms.BubbleSort(arrayToSort);
        Assert.Equal(sorted, arrayToSort);
    }
    [Fact]
    public void TestQuicksort()
    {
        int[] arrayToSort = { 3, 1, 5, 4, 7, 9, 6, 8, 2 };
        int[] sorted = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        sortAlgorithms.Quicksort(arrayToSort, 0, 8);
        Assert.Equal(sorted, arrayToSort);
    }
    [Fact]
    public void TestLinearSearch()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Assert.Equal(3, searchAlgorithms.LinearSearch(array, 4));
    }
    [Fact]
    public void TestBinarySearchImplementation()
    {
        int[] expectedXValues = { 1, 2, 3, 4, 5, 6, 8, 9, 10, 23, 24, 32, 48, 56, 64, 93, 128, 256, 512, 1024, 1213, 1440, 2048, 2414 };
        int[] samplePool = {
            1,2,3,4,5,6,7,8,9,10,12,24,32,48,56,64,128,256,512,1024,2048, 1213, 1440, 2414, 93, 23,
        };
        Array.Sort(samplePool);
        foreach (var value in expectedXValues)
        {
            int result = searchAlgorithms.BinarySearchImplementation(samplePool, value);
            Assert.Equal(Array.IndexOf(samplePool, value), result);
        }
    }
}