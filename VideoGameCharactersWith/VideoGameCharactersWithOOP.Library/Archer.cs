using System;
namespace VideoGameCharactersWithOOP.Library
{
    public class Archer : ActiveCharacter
    {
        public Archer(string name, int health, int level = 1, int experience = 0)
            : base(name, health, level, experience) { }

        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name} shoots an Arrow Barrage!");
            Experience += 15;
            if (Experience >= 100) LevelUp();
        }
    }
}