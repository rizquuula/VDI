namespace UnitTest;
using Anagram;

public class TestAnagram
{
    [SetUp]
    public void Setup()
    {
        
    }

    [TestCase(
        new string[]{"cinema", "host", "aba", "train"}, 
        new string[]{ "iceman", "shot", "bab", "rain"}, 
        ExpectedResult = "1100")]
    public string Test_Anagram(string[] firstWords, string[] secondWords)
    {
        var anagram = new Anagram(firstWords, secondWords);
        return anagram.CheckAnagrams();
    }
}