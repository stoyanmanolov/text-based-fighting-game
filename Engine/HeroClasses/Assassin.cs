using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.HeroClasses
{
    public class Assassin : Hero
    {
        public Assassin(string name) : base(name)
        {
            this.Name = name;
        }

        // Special ability method

        public override int Attack(Hero hero)
        {
            int tripleDamagePercentage = 30;
            int randomValue = random.Next(0, 100 + 1);
            if (randomValue <= tripleDamagePercentage)
            {
                int tripleDamage = RandomizeDamage() * 3;
                base.Attack(hero, tripleDamage);
                return tripleDamage;
            }
            return base.Attack(hero);
        }
    }
}
