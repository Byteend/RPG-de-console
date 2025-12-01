public class ShadowKnight : Enemy
{

    public override object Clone()
    {
        return new ShadowKnight();
    }

    public ShadowKnight()
    {
        Random rand = new Random();
        maxHp = 25;
        maxAttack = 8;
        maxDefense = 12;
        maxAccuracy = 5;
        dropXp = 25;
        name = "Shadow Knight";
        dropGold = 9 + rand.Next(9, 18);
        enemyType = EnemyTypes.Ghost;
        ResetStats();
    }
}