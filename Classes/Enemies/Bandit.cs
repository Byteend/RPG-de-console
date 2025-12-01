public class Bandit : Enemy
{

    public override object Clone()
    {
        return new Bandit(); 
    }

    public Bandit()
    {
        Random rand = new Random();
        maxHp = 20;
        maxAttack = 6;
        maxDefense = 9;
        maxAccuracy = 4;
        dropXp = 22;
        name = "Bandit";
        dropGold = 15 + rand.Next(12, 24);
        enemyType = EnemyTypes.Human;
        ResetStats();
    }
}