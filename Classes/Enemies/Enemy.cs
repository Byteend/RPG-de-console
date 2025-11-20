public abstract class Enemy : Entity, ICloneable
{
    protected float dropXp;
    protected int dropGold;
    public enum EnemyTypes
    {
        Undead,
        Ghost,
        Plant,
        Human
    }

    protected EnemyTypes enemyType;

    public abstract object Clone();

    public int getDropGold()
    {
        return dropGold;
    }
    public float getDropXp()
    {
        return dropXp;
    }
    public EnemyTypes GetEnemyType()
    {
        return enemyType;
    }
    
}