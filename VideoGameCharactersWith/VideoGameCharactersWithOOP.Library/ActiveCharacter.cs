using System;
namespace VideoGameCharactersWithOOP.Library
{
    public abstract class ActiveCharacter : GameCharacterBase, IActive
    {
        protected ActiveCharacter(string name, int health, int level = 1, int experience = 0)
            : base(name, health, level, experience)
        {
        }

        public override void LevelUp()
        {
            Level++;
            Experience = 0;
            Health += 10;  
            Console.WriteLine($"{Name} leveled up to {Level}!");
        }
    }
}
