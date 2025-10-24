using System;

namespace VideoGameCharactersWithOOP.Library
{
    public class Warrior : ActiveCharacter
    {
        public Warrior(string name, int health, int level = 1, int experience = 0)
            : base(name, health, level, experience) { }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} uses Sword Slash!");
            Experience += 20;
            if (Experience >= 100) LevelUp();
        }
    }
}