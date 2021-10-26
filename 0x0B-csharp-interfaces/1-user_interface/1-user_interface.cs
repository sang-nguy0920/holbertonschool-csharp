using System;

///<summary> Abstract base class. </summary>
public abstract class Base
{
    ///<summary> public property </summary>
    public string name { get; set; }

    ///<summary> ToString() method </summary>
    public override string ToString()
    {
        return (this.name) + " is a " + (this.GetType());
    }
}

///<summary> interface called IInteractive </summary>
interface IInteractive
{
    void Interact();
}

///<summary> interface called IBreakable </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

///<summary> interface called ICollectable </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; } = 1;
    public bool isCollected { get; set; } = false;
    public void Interact()
    {
    }
    public void Break()
    {
    }
    public void Collect()
    {
    }
}
