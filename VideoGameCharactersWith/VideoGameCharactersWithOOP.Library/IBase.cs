// This interface is for basic game character properties and actions
namespace VideoGameCharactersWithOOP.Library
{
    public interface IGameCharacter
    {
        string Name { get; set; } // Character name
        int Health { get; set; } // Character health

        void TakeDamage(int damage); // Method to apply damage
    }
}