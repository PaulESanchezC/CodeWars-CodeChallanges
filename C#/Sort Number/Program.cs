
int[] arr = new[] { 1, 10, 2, 50,5 };
Kata.SortNumbers(arr).ToList().ForEach(number => Console.WriteLine(number));

public static class Kata
{
    public static int[] SortNumbers(int[] nums)
    {
        Array.Sort(nums);
        return nums;
    }
}