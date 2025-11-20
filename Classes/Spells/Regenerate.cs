public class Regenerate : Spell
{
    public Regenerate()
    {
        spellName = "Regenerate";
        manaCost = 7;
    }

    public override void UseSpell(Player user, Enemy enemy)
    {
        user.heal(12);


    }
}