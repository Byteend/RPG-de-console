using System.Security.Cryptography;

public class Player : Entity
{
    
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

    public override void ResetStats() //Talvez precise adicionar algo neste override no futuro
    {
        base.ResetStats();
    }

    public void UpdateStats() //substituido por SetStats na classe pai
    {
        maxHp = baseHp + (level * hpPerLvl);
        maxMana = baseMana + (level * manaPerLvl);
        maxAttack = baseAttack + (level * attackPerLvl);
        maxAccuracy = baseAccuracy + (level * accuracyPerLvl);
        maxDefense = baseDefense + (level * defensePerLvl);
    }

   

    public void giveGold(int amount)
    {
        goldAmount += amount;
    }

    public void takeGold(int amount)
    {
        goldAmount = Math.Clamp(goldAmount - amount, 0, 99999999);
    }

  
    public int getGold()
    {
        return goldAmount;
    }

}