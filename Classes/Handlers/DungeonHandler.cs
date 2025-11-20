public class DungeonHandler : Dungeon
{
    public Dungeon createDungeon(int maxEnemies, DungeonType dungeonType)
    {
        List<Enemy> possibleEnemies = new List<Enemy>();
        Dungeon dungeon = new Dungeon();
        dungeon.setMaxEnemies(maxEnemies);
        Random rand = new Random();

        dungeon.setDungeonType(dungeonType);


        switch (dungeonType)
        {
            case DungeonType.Cave:
                possibleEnemies.Add(new Zombie());
                possibleEnemies.Add(new Skeleton());
                possibleEnemies.Add(new ShadowKnight());
                possibleEnemies.Add(new CarnivourousPlant());
                possibleEnemies.Add(new Bandit());
                break;
        }

        for (int i = 0; i < maxEnemies; i++)
        {
            Enemy chosenEnemy = possibleEnemies[rand.Next(0, possibleEnemies.Count())];
            dungeon.enemies.Add((Enemy)chosenEnemy.Clone());
        }

        return dungeon;
    }

    public void doDungeonAdventure(int maxEnemies, DungeonType dungeonType, Player player)
    {
        Dungeon dungeon = createDungeon(maxEnemies, dungeonType);
        battleHandler battleHandler = new battleHandler();

        foreach (Enemy e in dungeon.enemies)
        {
            Console.Clear();
            Console.WriteLine("You found a " + e.getName());
            Console.ReadLine();
            battleHandler.battle(player, e);

            if (player.getHp() <= 0)
            {
                return;
            }
            
        }

        if (player.getHp() > 0)
        {
            Console.Clear();
            Console.WriteLine("You explored the entire dungeon and defeated every enemy! Leaving the dungeon...");
            Console.ReadLine();
        }
    }
}