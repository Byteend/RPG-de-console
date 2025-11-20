using System.Security.Principal;

public class battleHandler
{
    public void battle(Player player, Enemy enemy)
    {
        while (player.getHp() > 0 && enemy.getHp() > 0)
        {
            battleMenu(player, enemy);
            if (enemy.getHp() > 0)
            {
                enemy.doAttack(player);
                Console.ReadLine();
            }
            Console.Clear();
        }
        if (player.getHp() <= 0)
        {
            Console.WriteLine("You see the light fading... You died!");

        }
        else
        {
            Console.WriteLine("You defeated the enemy!");
            Console.WriteLine("You gained " + enemy.getDropXp() + "XP & " + enemy.getDropGold() + " Gold");
            player.UpdateXp(enemy.getDropXp());
            player.giveGold(enemy.getDropGold());
            Console.ReadLine();
        }
    }


    private void battleMenu(Player player, Enemy enemy)
    {
        int choice = 0;
        bool status = false;
        do
        {
            while (choice < 1 || choice > 3)
            {
                Console.WriteLine(player.getName() + ": " + player.getHp() + "/" + player.getMaxHp());
                Console.WriteLine(player.getName() + ": " + player.getMana() + "mana");
                Console.WriteLine();
                Console.WriteLine(enemy.getName() + ": " + enemy.getHp() + "/" + enemy.getMaxHp());
                Console.WriteLine();
                Console.WriteLine("Choose an action:");
                Console.WriteLine("-----------------");
                Console.WriteLine("1) Attack!");
                Console.WriteLine("2) Use spell!");
                Console.WriteLine("3) Use item!");
                Console.WriteLine("-----------------");

                string? input = Console.ReadLine();
                bool valid = int.TryParse(input, out choice);

                if (!valid || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid Choice! Choose again!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.Clear();

            switch (choice)
            {
                case 1:
                    player.doAttack(enemy);
                    status = true;
                    break;
                case 2:
                    status = chooseSpell(player, enemy);
                    break;
                case 3:
                    player.inventory.useItem(player, enemy);
                    status = true;
                    break;
            }

            choice = 0; 
            
        } while (!status);


        Console.ReadLine();
        Console.Clear();
    }

    public bool chooseSpell(Player user, Enemy enemy) // Lembrete: Colocar função de usar spell dentro na classe do jogador e não no battleHandler.
    {
        int choice;
        int number;
        bool spellCheck;
        Console.WriteLine("Choose your spell:");


        choice = 0;
        while (choice < 1 || choice > user.spellList.Count)
        {

            number = 1;
            foreach (Spell s in user.spellList)
            {

                Console.WriteLine(number + ") " + s.getSpellName());
                number++;
            }

            string? input = Console.ReadLine();
            bool valid = int.TryParse(input, out choice);

            if (!valid || choice < 1 || choice > user.spellList.Count)
            {
                Console.WriteLine("Invalid choice! Choose again!");
                Console.ReadLine();
                Console.Clear();
            }
        }
        choice--;
        spellCheck = user.spellList[choice].trySpell(user, enemy);
        return spellCheck;

    }
}







