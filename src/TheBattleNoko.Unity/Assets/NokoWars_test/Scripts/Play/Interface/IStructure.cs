namespace NokoWars_test.Scripts.Play.Interface
{
    public interface IStructure
    {
        float getHP();
        float getLifeTime();
        bool isAlive();
        bool activate();
        bool deactivate();
        void damage(int damage);
        IUnit spawnUnit();
        void place(int x, int y);
    }
}