public class ManaPotion : Item
{
    private float manaRegenAmout;

    public ManaPotion()
    {
        itemName = "Mana Potion";
        goldCost = 10;
        manaRegenAmout = 10;
        itemDescription = "Regen your character 10 Mana";
    }

    public override void useItem(Player user, Enemy target)
    {
        base.useItem(user, target);
        Console.WriteLine(user.getName() + " Regen " + manaRegenAmout + " of mana");
        user.regenMana(manaRegenAmout);

    }
}