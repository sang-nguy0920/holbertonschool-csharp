using System;

///<summary> public class called Player </summary>
class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }

    ///<summary>Constructor for Player class.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.name = name;
        this.hp = this.maxHp;
    }

    ///<summary> PrintHealth() </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary> for checker </summary>
    delegate void CalculateHealth(float health);

    /// <summary> for checker </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            damage = 0f;
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{this.name} takes {damage} damage!");
        }
        this.hp -= damage;
        ValidateHP(this.hp);
    }

    /// <summary> for checker</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            heal = 0f;
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{this.name} heals {heal} HP!");
        }
        this.hp +=heal;
        ValidateHP(this.hp);
    }

    ///<summary> for checker</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
        {
            this.hp = 0f;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }

    ///<summary> for checker</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        else if (modifier == Modifier.Weak)
        {
            return baseValue / 2f;
        }
        else
        {
            return baseValue;
        }
    }
}

/// <summary> for checker</summary>
enum Modifier
{
    Weak,
    Base,
    Strong
}
/// <summary> for checker</summary>
delegate float CalculateModifier(float baseValue, Modifier modifier);
