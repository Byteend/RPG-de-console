public class Dungeon
{
    private int maxEnemies;
    public enum DungeonType
    {
        Mountain,
        Cave,
        Jungle,
        Ice,
        ShadowRealm,
        Chaotic,
        Desert
    }

    DungeonType dungeonType;
    public List<Enemy> enemies = new List<Enemy>();


    public void addEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
    }
    public int getMaxEnemies()
    {
        return maxEnemies;
    }

    public void setMaxEnemies(int value)
    {
        maxEnemies = value;
    }

    public DungeonType GetDungeonType()
    {
        return dungeonType;
    }

    public void setDungeonType(DungeonType dungeonType)
    {
        this.dungeonType = dungeonType;
    }
}