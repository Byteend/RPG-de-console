public class criticalAttack : Spell
{
    public criticalAttack()
    {
        spellName = "Critical Attack";
        manaCost = 9;
    }

    public override void  UseSpell(Player player, Enemy target)
    {
        float crtAttack = player.getAttack() * 2;
        Console.WriteLine(player.getName() + " Hard swipe it sword, causing a critical attack!");
        target.causeDamage(crtAttack);
        

    }
}