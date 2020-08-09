using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.HeroClasses
{
    public class Monk : Hero
    {
        public Monk(string name) : base(name)
        {
            this.Name = name;
        }

        // Special ability method

        protected override int Defend(int attackedDamage)
        {
            int avoidPercentage = 30;
            int randomValue = random.Next(0, 100 + 1);
            if (randomValue <= avoidPercentage)
            {
                attackedDamage = 0;
                return attackedDamage;
            }
            return base.Defend(attackedDamage);
        }
    }
}
