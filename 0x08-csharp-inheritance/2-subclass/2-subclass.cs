using System;


/// <summary>Public Obj class.</summary>
class Obj
{
    /// <summary>Public Obj class.</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
