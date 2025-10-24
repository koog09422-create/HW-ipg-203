// This interface is for active characters with more features
namespace VideoGameCharactersWithOOP.Library
{
    public interface IActive : IGameCharacter
    {
        int Level { get; set; } // Character level
        int Experience { get; set; } // Character experience
        void LevelUp(); // Method to level up
        void SpecialAbility(); // Method for special ability
    }
}
