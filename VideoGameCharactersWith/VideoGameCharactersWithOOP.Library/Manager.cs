using System;
using System.Collections.Generic; 
// This class manages all game characters
namespace VideoGameCharactersWithOOP.Library
{
    public class Manager
    {
        private readonly List<GameCharacterBase> characters = new List<GameCharacterBase>(); // List of characters

        // Add a character to the list
        public void AddCharacter(GameCharacterBase character)
        {
            characters.Add(character);
            character.OnDeath += HandleCharacterDeath; // Subscribe to death event
        }

        // Show all characters with their info
        public void ShowAllCharacters()
        {
            foreach (var character in characters)
            {
                Console.WriteLine($"Character: {character.Name}, Health: {character.Health}, Level: {character.Level}, Exp: {character.Experience}");
            }
        }

        // Get the list of characters
        public List<GameCharacterBase> GetCharacters()
        {
            return characters;
        }

        // Handle character death event
        private void HandleCharacterDeath(GameCharacterBase character)
        {
            Console.WriteLine($"{character.Name} has died.");
        }
    }
}