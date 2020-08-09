using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.HeroClasses
{
    public class Knight : Hero
    {
        public Knight(string name) : base(name)
        {
            this.Name = name;
        }

        // Special ability methods

        public override int Attack(Hero hero)
        {
            int doubleDamagePercentage = 10;
            int randomValue = random.Next(0, 100 + 1);
            if (randomValue <= doubleDamagePercentage)
            {
                int doubleDamage = RandomizeDamage() * 2;
                base.Attack(hero, doubleDamage);
                return doubleDamage;
            }
            return base.Attack(hero);
        }
        protected override int Defend(int attackedDamage)
        {
            int blockPercentage = 20;
            int randomValue = random.Next(0, 100 + 1);
            if (randomValue <= blockPercentage)
            {
                attackedDamage = 0;
                return attackedDamage;
            }
            return base.Defend(attackedDamage);
        }
    }
}
