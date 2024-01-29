namespace UnitTest;
using SplitFlip;

public class TestSplitFlip
{
    [SetUp]
    public void Setup()
    {
        
    }

    [TestCase("123456", ExpectedResult = "321654")]
    [TestCase("ABCDEF", ExpectedResult = "CBAFED")]
    [TestCase("BA3&H-M", ExpectedResult = "3AB&M-H")]
    public string Test_SplitFlip(String input)
    {
        var splitFlip = new SplitFlip(input);
        return splitFlip.DoSplitFlip();
    }
}