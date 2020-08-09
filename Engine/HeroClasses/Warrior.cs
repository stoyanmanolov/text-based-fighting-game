using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.HeroClasses
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
