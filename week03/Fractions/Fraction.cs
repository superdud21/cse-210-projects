using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int topNumber)
    {
        _top = topNumber;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double fractionDecimal = (double)_top/(double)_bottom;
        return fractionDecimal;
    }

    public int GetTop()
    {
        return _top;
    }
    
    public void SetTop(int topNumber)
    {
        _top = topNumber;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottomNumber)
    {
        _bottom = bottomNumber;
    }
}
