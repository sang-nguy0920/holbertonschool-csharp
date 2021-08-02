using System;

/// <summary>Base Shape class.</summary>
class Shape
{
    /// <summary>Base Shape class.</summary>
    public virtual int Area()
    {
        throw new System.NotImplementedException("Area() is not implemented");
    }

}

/// <summary>Base Rectangle class.</summary>
class Rectangle:Shape
{
    private int width;
    private int height;

    public int Width
    {
        get {return (width);}
        set{
            if (value < 0)
            throw new System.ArgumentException("Width must be greater than or equal to 0");
            else
            width = value;
        }
    }

    public int Height
    {
        get {return (height);}
        set{
            if (value < 0)
            throw new System.ArgumentException("Height must be greater than or equal to 0");
            else
            height = value;
        }
    }

    public new int Area()
    {
        return (width * height);
    }

    public override string ToString()
    {
        return String.Format("[Rectangle] {0} / {1}", width, height);
    }
}

/// <summary>Square class.</summary>
class Square:Rectangle
{
    private int size;
    public int Size
    {
        get {return (size);}
        set{
            if (value < 0)
            throw new System.ArgumentException("Size must be greater than or equal to 0");
            else
            size = value;
            Height = value;
            Width = value;
        }
    }

}
