public class CarnivourousPlant : Enemy
{

    public override object Clone()
    {
        return new CarnivourousPlant();
    }

    public CarnivourousPlant()
    {
        Random rand = new Random();
        maxHp = 40;
        maxAttack = 3;
        maxDefense = 5;
        maxAccuracy = 8;
        dropXp = 20;
        name = "Carnivourous Plant";
        dropGold = 6 + rand.Next(7, 14);
        enemyType = EnemyTypes.Plant;
        ResetStats();
    }
}