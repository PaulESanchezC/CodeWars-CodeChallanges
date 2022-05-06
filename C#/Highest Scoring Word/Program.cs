var response = HighestScoringWord.GetHighestScoringWord("man i need a taxi up to ubud");
Console.WriteLine(response);

public class HighestScoringWord
{
    public static string GetHighestScoringWord(string sentence)
    {
        List<string> wordList = new();
        List<(int key,string value)> mvpList = new();

        wordList.AddRange(sentence.Split().ToList());
        wordList.ForEach(word =>
        {
            mvpList.Add((word.ToCharArray().Length,word));
        });

        var mvpIndex = mvpList.Max().key;

        return mvpList[mvpIndex].value;
    }
}