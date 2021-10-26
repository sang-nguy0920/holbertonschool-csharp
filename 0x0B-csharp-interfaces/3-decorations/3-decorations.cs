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

///<summary> checker </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem = false;
    public int durability { get; set; }

    ///<summary> checker </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 1)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary> checker </summary>
    public void Interact()
    {
        if (durability < 1)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    ///<summary> checker </summary>
    public void Break()
    {
        durability -= 1;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else if (durability < 0)
            Console.WriteLine($"The {name} is already broken.");
    }
}
