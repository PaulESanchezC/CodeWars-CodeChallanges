

Kata.GetDaysAlive(1987, 1, 16, 2000, 10, 15);
public static class Kata
{
    public static long GetDaysAlive(int year, int month, int day, int year2, int month2, int day2)
    {
        var date1 = DateTime.Parse($"{month}-{day}-{year}");
        var date2 = DateTime.Parse($"{month2}-{day2}-{year2}");
        return (date2 - date1).Days;
    }
}