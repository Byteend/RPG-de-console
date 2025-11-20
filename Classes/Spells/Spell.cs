public abstract class Spell
{
    protected float manaCost;
    protected string spellName = "";

    public string getSpellName()
    {
        return spellName;
    }


    public abstract void UseSpell(Player player, Enemy enemy);
   

    public bool trySpell(Player player, Enemy enemy)
    {
        if (player.getMana() >= manaCost)
        {
            Console.WriteLine(player.getName() + " uses " + spellName);
            UseSpell(player, enemy);
            player.consumeMana(manaCost);
            return true;
        }
        else
        {
            Console.WriteLine("User has not enough mana!");
            Console.ReadLine();
            return false;
        }
    }
}