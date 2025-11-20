public class Zombie : Enemy
{

    public override object Clone()
    {
        return new Zombie();
    }

    public Zombie()
    {
        Random rand = new Random();
        maxHp = 15;
        maxAttack = 5;
        maxDefense = 10;
        maxAccuracy = 3;
        dropXp = 15;
        name = "Zombie";
        dropGold = 5 + rand.Next(7, 13);
        enemyType = EnemyTypes.Undead;
        setStats();
    }
}