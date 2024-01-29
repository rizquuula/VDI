namespace SplitFlip;

public class SplitFlip
{
    private readonly string _input;
    private string _output;

    public SplitFlip(string text)
    {
        _input = text;
        _output = "";
    }
    
    public string DoSplitFlip()
    {
        bool isEven = _input.Length % 2 == 0;
        if (isEven)
        {
            int splitLength = this._input.Length / 2;
            string left = _input.Substring(0, splitLength);
            string right = _input.Substring(splitLength, splitLength);

            string leftReversed = reverseString(left);
            string rightReversed = reverseString(right);
            _output = leftReversed + rightReversed;
        }
        else
        {
            int splitLength = (_input.Length - 1) / 2;
            string left = _input.Substring(0, splitLength);
            string mid = _input.Substring(splitLength, 1);
            string right = _input.Substring(splitLength + 1, splitLength);

            string leftReversed = reverseString(left);
            string rightReversed = reverseString(right);
            _output = leftReversed + mid + rightReversed;
        }
        return _output;
    }

    private string reverseString(string text)
    { 
        return new String(text.Reverse().ToArray()); 
    }

    static void Main()
    {
        
    }
}