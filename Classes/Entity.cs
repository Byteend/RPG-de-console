using System.Text.Json.Serialization.Metadata;

public class Entity
{
    protected float hp, maxHp, hpPerLvl, baseHp;
    protected float attack, maxAttack, attackPerLvl, baseAttack;
    protected float accuracy, maxAccuracy, accuracyPerLvl, baseAccuracy;
    protected float defense, maxDefense, defensePerLvl, baseDefense;
    protected string name = "";

    public string getName()
    {
        return name;
    }

    public float getHp()
    {
        return hp;
    }

    public float getMaxHp()
    {
        return maxHp;
    }

    public void setHp(float value)
    {
        hp = Math.Clamp(value, 0, maxHp);
    }

    public void heal(float value)
    {
        hp = Math.Clamp(hp + value, 0, maxHp);
        Console.WriteLine(name + " healed " + value + " of HP!");
       
    }

    public void causeDamage(float value)
    {
        hp -= Math.Clamp(value, 0, maxHp);
        Console.WriteLine(name + " took " + value + " damage!");
        
    }
    
    public float getAttack()
    {
        return attack;
    }

    public void doAttack(Entity target)
    {
        int hitValue;
        Random dice = new Random();
        hitValue = (int)accuracy + dice.Next(1, 21);
        if (hitValue > target.defense)
        {
            target.hp -= attack;
            Console.WriteLine(name + " successfully attack " + target.getName());
        }
        else
        {
            Console.WriteLine(name + " attack had failed!");
        }
    }
    public virtual void setStats()
    {
        hp = maxHp;
        attack = maxAttack;
        accuracy = maxAccuracy;
        defense = maxDefense;
    }
}