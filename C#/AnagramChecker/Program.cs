AnagramTools.AnagramCheck("anagram", "gramana");

public class AnagramTools
{
    public static void AnagramCheck(string input, string output)
    {
        var inputCharacters = input.ToCharArray().ToList();
        var checker = new Dictionary<char, int>();

        var i = 0;
        inputCharacters.ForEach(letter =>
            {
                if (output.Contains(letter))
                    checker.TryAdd(letter, i++);
            });

        Console.WriteLine(checker.Keys.Count == output.Distinct().Count());
    }
}