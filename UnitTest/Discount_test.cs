namespace UnitTest;
using Discount;

public class TestDiscount
{
    [SetUp]
    public void Setup()
    {
        
    }

    [TestCase("platinum", 200, 500, 285, 215)]
    [TestCase("gold", 396, 100, 59, 41)]
    public void Test_Anagram(string customerType, int point, int totalSpending, int discountTarget, int paidAmountTarget)
    {
        var disc = new Discount(customerType, point, totalSpending);
        var discount = disc.SumDiscount();
        var paidAmount = disc.PaidAmount();
        
        Assert.AreEqual(discount, discountTarget);
        Assert.AreEqual(paidAmount, paidAmountTarget);
    }
}