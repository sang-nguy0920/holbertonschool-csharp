using System;

///<summary> Abstract base class. </summary>
public abstract class Base
{
    ///<summary> public property </summary>
    public string name;

    ///<summary> ToString() method </summary>
    public override string ToString()
    {
        return (name + " is a " + this.GetType().ToString());
    }
}
