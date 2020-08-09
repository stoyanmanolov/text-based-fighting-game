using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.HeroClasses
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            this.Name = name;
        }

        // Special ability methods

        public override int Attack(Hero hero)
        {
            int doubleDamagePercentage = 30;
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
            int avoidPercentage = 30;
            int randomValue = random.Next(0, 100 + 1);
            if (randomValue <= avoidPercentage)
            {
                attackedDamage += attackedDamage / 2;
                return attackedDamage;
            }
            return base.Defend(attackedDamage);
        }
    }
}
