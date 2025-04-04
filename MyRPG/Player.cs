using System;

namespace MyRPG
{
    public class Player
    {
        private int xp;
        private float health;
        public string Name { get; }
        
        public Player(string name)
        {
            this.Name = name;
            xp = 0;
            Health = MaxHealth;
        }

        public int XP
        {
            get => xp;
            set
            {
                if (value > xp) xp = value;
            }
        }
        
        public float Health
        {
            set
            {
               if (health > MaxHealth)
               { 
                health= MaxHealth;
               }
            }
            get
            {
                return health;
            }
            
        }

        public float MaxHealth
        {
            get => 100f + (Level - 1) * 20f;
        }
        
        public void TakeDamage(float damage)
        {
            Health -= damage;
            XP += (int)damage / 20;
        }

        public int Level 
        {
        get => 1 + XP / 1000;
        }
    }
}
