public class HealingPotion : Item
{
    private float healAmout;

    public HealingPotion()
    {
        itemName = "Healing Potion";
        goldCost = 10;
        healAmout = 10;
        itemDescription = "Heal your character 10 HP";
    }

    public override void useItem(Player user, Enemy target)
    {
        base.useItem(user, target);
        user.heal(healAmout);
    }
}