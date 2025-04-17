using System;
using UnityEngine;

namespace NokoWars_test.Scripts.Play
{
    public class Player
    {
        private float HP;
        private int cost;

        public float getHP()
        {
            return HP;
        }

        public int getCost()
        {
            return cost;
        }

        public void damage(int damage)
        {
            HP = Mathf.Max(0, HP - damage);
        }
    }
}