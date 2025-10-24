using System;
namespace VideoGameCharactersWithOOP.Library
{
    public class Healer : ActiveCharacter
    {
        public Healer(string name, int health, int level = 1, int experience = 0)
            : base(name, health, level, experience) { }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} heals an ally!");
            Experience += 30;
            if (Experience >= 100) LevelUp();
        }
    }
}
