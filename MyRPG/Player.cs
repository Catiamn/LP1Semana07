using System;

namespace MyRPG
{
    public class Player
    {
        private int xp;
        private float float;
        public string Name
        public int XP
        {
            get => xp;
            int xp = 0;
            int xp += value
            if (value < = 0)
            {
                xp = 0;
            }
        }
        public int Level
        {
            int Level = 1 + XP / 1000;
        }
        public float MaxHealth
        {
            float readonly MaxHealth = 100 + (Level - 1) * 20;
        }
        
        public void TakeDamage(float damage)
        {
            float damage = value;
            int health -= damage;
            int xp += (int)damage/20
        }
    }
}