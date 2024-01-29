namespace Anagram;

public class Anagram
{
    private readonly string[] _firstWords;
    private readonly string[] _secondWords;
    private string _output;
    public Anagram(string[] firstWords, string[] secondWords)
    {
        _firstWords = firstWords;
        _secondWords = secondWords;
        _output = "";
    }
    
    public string CheckAnagrams()
    {
        for (var i = 0; i < _firstWords.Length; i++)
        {
            if (IsAnagram(_firstWords[i], _secondWords[i]))
            {
                _output += "1";
            }
            else
            {
                _output += "0";
            }
        }
        return _output;
    }

    private bool IsAnagram(string a, string b)
    {
        var aArray = a.ToArray();
        var bArray = b.ToArray();
        
        Array.Sort(aArray);
        Array.Sort(bArray);
        
        var aSorted = new String(aArray);
        var bSorted = new String(bArray);
        
        return Equals(aSorted, bSorted);
    }
}