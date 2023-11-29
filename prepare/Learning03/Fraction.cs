using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // No argument constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with numerator only
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }


    // Constructor with both numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Method to get the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to get the decimal value of the fraction 
    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }

}