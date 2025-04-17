using System;

namespace NokoWars_test.Scripts.Play.Interface
{
    public interface IUnit
    {
        Tuple<float,float> getPosition();
        float getAttack();
        bool isAlive();
        void damage(int damage);
    }
}