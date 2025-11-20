public class AdventureHandler
{
    DungeonHandler dHandler = new DungeonHandler();
    Shop shop = new Shop();


    public static int PlayerChoice(int min, int max)
    {
        int choice = 0;
        string? input;
        bool valid = false;

        while (!valid)
        {
            valid = false;
            input = Console.ReadLine();
            valid = int.TryParse(input, out choice);

            if (!valid || choice < min || choice > max)
            {
                Console.WriteLine("Invalid Choice! Choose again");
                Console.ReadLine();
            }
        }

        return choice;
    }

    public int ChooseDestiny()
    {
        int choice;

        Console.WriteLine("Choose your destiny");
        Console.WriteLine("1) Dungeon");
        Console.WriteLine("2) Shop");

        choice = PlayerChoice(1, 2);

        return choice;
    }
}