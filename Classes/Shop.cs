public class Shop
{
    List<Item> shopList = new List<Item>();

    public Shop()
    {
        shopList.Add(new HealingPotion());
        shopList.Add(new ManaPotion());
    }

    public void showList(Player player)
    {
        int number = 1;
        Console.Clear();
        Console.WriteLine("Your gold: " + player.getGold() + "G");
        Console.WriteLine();
        foreach (Item s in shopList)
        {
            Console.WriteLine(number + ") |" + s.getGoldCost() + "G| -" + " " + s.getName() + " --> " + s.getDescription());
            number++;
        }


        
    }

    public void buyItem(Player player)
    {
        int choice = 0;
        int amount = 0;
        string? input = "";
        bool valid;

        while (choice < 1 || choice > shopList.Count())
        {
            showList(player);

            input = Console.ReadLine();
            valid = int.TryParse(input, out choice);
            if (!valid || choice < 1 || choice > shopList.Count())
            {
                Console.WriteLine("Invalid Choice! Choose again!");
                Console.ReadLine();
                Console.Clear();
            }
        }

        while (amount == 0)
        {
            Console.WriteLine("Type the amount");
            input = Console.ReadLine();
            valid = int.TryParse(input, out amount);

            if (!valid || amount < 0)
            {
                Console.WriteLine("Invalid amount! type again!");
                Console.ReadLine();
                Console.Clear();
            }

            if (amount == 0)
            {
                Console.WriteLine("You didn't bought anything. Good bye!");
                Console.ReadLine();
                return;
            }
        }

        if (amount > 0)
        {
            choice--;
            int totalCost = shopList[choice].getGoldCost() * amount;
            if (player.getGold() >= totalCost)
            {
                player.inventory.addItem(shopList[choice], amount);
                player.takeGold(totalCost);
                Console.WriteLine("You bought " + amount + " units of " + shopList[choice].getName());
                Console.WriteLine("You give " + totalCost + " of gold");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You don't have enough gold! The total cost is " + totalCost + "G and you have only " + player.getGold() + "G");
                Console.ReadLine();
            }
        }


    }

    public void shopMenu(Player player)
    {
        int choice = 0;
        string? input = "";
        bool valid;

        while (choice != 3)
        {
            Console.WriteLine("Your gold: " + player.getGold() + "G");
            Console.WriteLine();
            Console.WriteLine("Select one option:");
            Console.WriteLine("1) See itens on catalogue");
            Console.WriteLine("2) Buy an item");
            Console.WriteLine("3) Exit");

            input = Console.ReadLine();
            valid = int.TryParse(input, out choice);

            if (!valid)
            {
                Console.WriteLine("Invalid Choice! Choose again!");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        showList(player);
                        Console.WriteLine("Press enter to close");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        buyItem(player);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Choose again!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        } 
    }
}