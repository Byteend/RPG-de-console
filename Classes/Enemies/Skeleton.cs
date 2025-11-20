public class Skeleton : Enemy
{

    public override object Clone()
    {
        return new Skeleton();
    }

    public Skeleton()
    {
        Random rand = new Random();
        maxHp = 11;
        maxAttack = 8;
        maxDefense = 9;
        maxAccuracy = 5;
        dropXp = 15;
        name = "Skeleton";
        dropGold = 5 + rand.Next(7, 13);
        enemyType = EnemyTypes.Undead;
        setStats();
    }
}