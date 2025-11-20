public class InventoryHandler
{
    List<InventorySlot> Inventory = new List<InventorySlot>();

    public void showInventory()
    {
        int number = 1;
        foreach (InventorySlot i in Inventory)
        {
            Console.WriteLine(number + ") " + i.getName() + " Amount: " + i.getQuantity());
            number++;
        }
    }

    public void addItem(Item item, int quantity)
    {

        bool hasItem = false;
        foreach (InventorySlot i in Inventory)
        {
            if (i.getItem() == item)
            {
                i.increaseQuantity(quantity);
                hasItem = true;
            }

            if (hasItem)
            {
                return;
            }
        }

        if (!hasItem)
        {
            Inventory.Add(new InventorySlot(item, quantity));
        }

    }

    public void useItem(Player player, Enemy enemy)
    {
        int choice = -1;

        while (choice < 1 || choice > Inventory.Count())
        {
            showInventory();

            string? input = Console.ReadLine();
            bool valid = int.TryParse(input, out choice);

            if (choice == 0)
            {
                Console.WriteLine("No Item selected");
                Console.ReadLine();
                return;
            }

            if (!valid || choice < 1 || choice > Inventory.Count())
            {
                Console.WriteLine("Invalid Choice! Choose again!");
                Console.ReadLine();
                Console.Clear();
            }

        }

        choice--;
        Inventory[choice].useItem(player, enemy);
        Inventory[choice].DecreaseQuantity(1);
        if (Inventory[choice].getQuantity() <= 0)
        {
            Inventory.Remove(Inventory[choice]);
        }
        
                
    }
}