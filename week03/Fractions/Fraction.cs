using System;
using System.Diagnostics.Contracts;

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

    }

    public double GetDecimalValue()
    {

    }

    public void GetTop()
    {

    }
    
    public void SetTop(int topNumber)
    {

    }

    public void GetBottom()
    {

    }

    public void SetBottom(int bottomNumber)
    {

    }
}
