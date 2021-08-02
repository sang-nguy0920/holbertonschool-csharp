using System;


/// <summary>Public Obj class.</summary>
class Obj
{
    /// <summary>Public Obj class.</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return (typeof(Array).IsInstanceOfType(obj));
    }
}
