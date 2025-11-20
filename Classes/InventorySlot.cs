public class InventorySlot
{
    private Item item = new Item();
    private int quantity;
    private string name;

    public InventorySlot(Item item, int quantity)
    {
        this.quantity = quantity;
        this.item = item;
        name = item.getName();
    }

    public string getName()
    {
        return name;
    }

    public int getQuantity()
    {
        return quantity;
    }

    public Item getItem()
    {
        return item;
    }

    public void increaseQuantity(int value)
    {
        quantity += value;
    }

    public void DecreaseQuantity(int value)
    {
        quantity -= value;
    }

    public void useItem(Player user, Enemy target)
    {
        item.useItem(user, target);
    }
    
}