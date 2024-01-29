namespace Discount;

public class Discount
{
    private readonly string _customerType;
    private readonly int _point;
    private readonly int _totalSpending;
    private int _discount;
    private int _paidAmount;
    
    public Discount(string customerType, int point, int totalSpending)
    {
        _customerType = customerType;
        _point = point;
        _totalSpending = totalSpending;
        _discount = 0;
        _paidAmount = 0;
    }
    
    public int SumDiscount()
    {
        if (_customerType == "platinum" && _point is > 100 and <= 300)
        {
            _discount = (_totalSpending * 50 / 100) + 35;
        } 
        else if (_customerType == "platinum" && _point is > 300 and <= 500)
        {
            _discount = (_totalSpending * 50 / 100) + 50;
        }
        else if (_customerType == "platinum" && _point > 500)
        {
            _discount = (_totalSpending * 50 / 100) + 68;
        }
        else if (_customerType == "gold" && _point is > 100 and <= 300)
        {
            _discount = (_totalSpending * 25 / 100) + 25;
        } 
        else if (_customerType == "gold" && _point is > 300 and <= 500)
        {
            _discount = (_totalSpending * 25 / 100) + 34;
        }
        else if (_customerType == "gold" && _point > 500)
        {
            _discount = (_totalSpending * 25 / 100) + 52;
        }
        else if (_customerType == "silver" && _point is > 100 and <= 300)
        {
            _discount = (_totalSpending * 10 / 100) + 12;
        } 
        else if (_customerType == "silver" && _point is > 300 and <= 500)
        {
            _discount = (_totalSpending * 10 / 100) + 27;
        }
        else if (_customerType == "silver" && _point > 500)
        {
            _discount = (_totalSpending * 210 / 100) + 39;
        }
        
        return _discount;
    }

    public int PaidAmount()
    {
        _paidAmount = _totalSpending - _discount;
        return _paidAmount;
    }
}