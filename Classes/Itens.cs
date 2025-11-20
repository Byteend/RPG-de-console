public class Item
{
    protected int goldCost;
    protected string itemName = "";
    protected string itemDescription = "";

    public string getName()
    {
        return itemName;
    }

    public virtual void useItem(Player user, Enemy target)
    {
        Console.WriteLine(user.getName() + " uses " + itemName);
    }

    public int getGoldCost()
    {
        return goldCost;
    }

    public string getDescription()
    {
        return itemDescription;
    }
}