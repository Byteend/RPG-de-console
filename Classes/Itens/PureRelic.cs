public class PureRelic : Item
{
    private float damageAmount;

    public PureRelic()
    {
        itemName = "Pure Relic";
        goldCost = 25;
        damageAmount = 25;
        itemDescription = "Causes 25 damage on UNDEAD enemies";
    }

    public override void useItem(Player user, Enemy target)
    {
        base.useItem(user, target);

        if (target.GetEnemyType() == Enemy.EnemyTypes.Undead)
        {
            Console.WriteLine(target.getName() + " Takes " + damageAmount + " of damage");
            Console.ReadLine();
            target.causeDamage(damageAmount);
        }
        else
        {
            Console.WriteLine("You try to use the relic but the enemy is not a Undead. The relic breaks!");
            Console.ReadLine();
        }
        

    }
}