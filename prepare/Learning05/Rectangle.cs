using System;

class Rectangle : Shape
{

    private int _sideOne = 0;

    private int _sideTwo = 0;

    public Rectangle(string color, int sideOne, int sideTwo) : base(color)
    {
        SetColor(color);
        _sideOne = sideOne;
        _sideTwo = sideTwo;
    }

    public override double GetArea()
    {
        return _sideOne * _sideTwo;
    }
}