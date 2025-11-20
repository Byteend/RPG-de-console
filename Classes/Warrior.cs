public class Warrior : Player
{
    public Warrior(string name)
    {
        this.name = name;
        className = "Warrior";

        baseHp = 30; 
        hpPerLvl = 15;
        baseAttack = 5; 
        attackPerLvl = 2;
        baseAccuracy = 2; 
        accuracyPerLvl = 1;
        baseDefense = 8;
        defensePerLvl = 1.5f;
        baseMana = 10;
        manaPerLvl = 5;
        level = 1;

        spellList.Add(new Regenerate());
        spellList.Add(new criticalAttack());

        UpdateStats();
        setStats();
    }
}