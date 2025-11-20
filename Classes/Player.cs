using System.Security.Cryptography;

public class Player : Entity
{
    protected float mana, maxMana, manaPerLvl, baseMana;
    protected int level;
    protected int goldAmount;
    protected float xp, maxXp = 10, maxXpPerLevel = 7;
    protected string className = "No class";
    public List<Spell> spellList = new List<Spell>();
    public InventoryHandler inventory = new InventoryHandler();


    public void UpdateXp(float value)
    {
        xp += value;
        Console.WriteLine("You gained " + value + " Of Xp!");
        if (xp >= maxXp)
        {
            xp -= maxXp;
            level++;
            maxXp += maxXpPerLevel * level;
            Console.WriteLine("Your level increased to level " + level);
            UpdateStats();
        }
    }

    public override void setStats()
    {
        base.setStats();
        mana = maxMana;
    }

    public void UpdateStats()
    {
        maxHp = baseHp + (level * hpPerLvl);
        maxMana = baseMana + (level * manaPerLvl);
        maxAttack = baseAttack + (level * attackPerLvl);
        maxAccuracy = baseAccuracy + (level * accuracyPerLvl);
        maxDefense = baseDefense + (level * defensePerLvl);
    }

    public void consumeMana(float value)
    {
        mana = Math.Clamp(mana - value, 0, maxMana);
    }

    public void regenMana(float value)
    {
        mana = Math.Clamp(mana + value, 0, maxMana);
    }

    public void giveGold(int amount)
    {
        goldAmount += amount;
    }

    public void takeGold(int amount)
    {
        goldAmount = Math.Clamp(goldAmount - amount, 0, 99999999);
    }

    public float getMana()
    {
        return mana;
    }
    public int getGold()
    {
        return goldAmount;
    }

}