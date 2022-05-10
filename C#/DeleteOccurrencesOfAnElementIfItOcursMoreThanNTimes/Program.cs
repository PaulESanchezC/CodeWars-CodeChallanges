
public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        Dictionary<int, int> dictionary = new();
        arr.ToList().ForEach(item =>
       {
           if (!dictionary.ContainsKey(item))
               dictionary.Add(item, 1);
           dictionary[item] += dictionary[item] >= x ? 0 : 1;
       });
        return dictionary.Keys.ToArray();
    }
}