using System;

namespace VideoGameCharactersWithOOP.Library
{
    public class Mage : ActiveCharacter
    {
        public Mage(string name, int health, int level = 1, int experience = 0)
            : base(name, health, level, experience) { }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} casts Fireball!");
            Experience += 25;
            if (Experience >= 100) LevelUp();
        }
    }
}