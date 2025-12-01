using System.Text.Json.Serialization.Metadata;

public class Entity
{   
    protected float str, baseStr;
    protected float agi, baseAgi;
    protected float intl, baseIntl;
    protected float hp, maxHp, hpPerLvl /*remover depois */, baseHp, hpPerStr;
    protected float mana, maxMana, manaPerLvl, baseMana, manaPerIntl;
    protected float attack, maxAttack, attackPerLvl, baseAttack, atkPerStr;
    protected float accuracy, maxAccuracy, accuracyPerLvl, baseAccuracy, accPerAgi;
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
 public void consumeMana(float value)
    {
        mana = Math.Clamp(mana - value, 0, maxMana);
    }

    public void regenMana(float value)
    {
        mana = Math.Clamp(mana + value, 0, maxMana);
    }
      public float getMana()
    {
        return mana;
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
    public virtual void ResetStats()
    {
        hp = maxHp;
        mana = maxMana;
        attack = maxAttack;
        accuracy = maxAccuracy;
        defense = maxDefense;
    }

    public virtual void SetStats()
    {
        maxHp = baseHp + (str * hpPerStr);
        maxMana = baseMana + (intl * manaPerIntl);
        maxAttack = baseAttack + (str * atkPerStr);
        maxAccuracy = baseAccuracy + (agi * accPerAgi);
    }
}