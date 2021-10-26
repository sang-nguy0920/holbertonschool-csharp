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

///<summary> Door that inherits from Base and IInteractive class </summary>
public class Door : Base, IInteractive
{
    ///<summary> constructor </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    ///<summary> constructor </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
