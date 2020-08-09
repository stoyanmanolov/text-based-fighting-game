using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Hero
    {

        // Needed variables

        protected static Random random = new Random();
        int minPercentage = 80;
        int maxPercentage = 120;

        public Hero(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int AttackPoints { get; set; }
        public int ArmorPoints { get; set; }
        public void SetStats()
        {
            this.HealthPoints = 1500;
            this.AttackPoints = 250;
            this.ArmorPoints = 150;
        }

        // Helper methods

        protected int RandomizeDamage()
        {
            int percentage = random.Next(minPercentage, maxPercentage + 1);
            int damage = (AttackPoints * percentage) / 100;
            return damage;
        }
        protected void DeductDamage(Hero hero, int damage)
        {
            hero.HealthPoints -= damage;
        }

        // Attacking methods for standard attack and special ability attack

        public virtual int Attack(Hero hero)
        {
            int randomDamage = RandomizeDamage();
            int defendedDamage = hero.Defend(randomDamage);
            DeductDamage(hero, defendedDamage);
            return defendedDamage;
        }
        protected virtual int Attack(Hero hero, int damage)
        {
            int defendedDamage = hero.Defend(damage);
            DeductDamage(hero, defendedDamage);
            return defendedDamage;
        }

        // Defending damage method

        protected virtual int Defend(int attackedDamage)
        {
            int percentage = random.Next(minPercentage, maxPercentage + 1);
            int reducedDamage = (ArmorPoints * percentage) / 100;
            int damage = attackedDamage - reducedDamage;
            return damage;
        }
    }
}
