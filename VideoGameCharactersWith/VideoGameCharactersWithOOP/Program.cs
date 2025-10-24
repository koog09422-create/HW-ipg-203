using System;
using VideoGameCharactersWithOOP.Library;
using System.Collections.Generic;
namespace VideoGameCharactersWithOOP
{
    internal class Program
    {
        // Main method: Entry point for the program
        static void Main(string[] args)
        {
            Manager manager = new Manager(); // Create manager to handle characters
            bool running = true;
            Console.WriteLine("=== Video Game Characters Manager ===\n");
            while (running)
            {
                // Show menu to user
                Console.WriteLine("\nSelect an action:");
                Console.WriteLine("1. Add a new character");
                Console.WriteLine("2. Apply damage to a character");
                Console.WriteLine("3. Use special ability for a character");
                Console.WriteLine("4. Show all characters");
                Console.WriteLine("5. Exit");
                Console.Write("Your choice: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddCharacter(manager); // Add character
                        break;
                    case "2":
                        DamageCharacter(manager); // Damage character
                        break;
                    case "3":
                        UseSpecialAbility(manager); // Use special ability
                        break;
                    case "4":
                        manager.ShowAllCharacters(); // Show all characters
                        Console.WriteLine($"Total characters: {GameCharacterBase.TotalCharacters}");
                        break;
                    case "5":
                        running = false; // Exit program
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            Console.WriteLine("Program terminated.");
        }

        // Add a new character to the manager
        static void AddCharacter(Manager manager)
        {
            Console.WriteLine("Select character type:");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Archer");
            Console.WriteLine("4. Healer");
            Console.Write("Your choice: ");
            var type = Console.ReadLine();
            Console.Write("Character name: ");
            var name = Console.ReadLine();
            Console.Write("Health: ");
            int health = int.TryParse(Console.ReadLine(), out int h) ? h : 100;
            GameCharacterBase character = null;
            switch (type)
            {
                case "1": character = new Warrior(name, health); break;
                case "2": character = new Mage(name, health); break;
                case "3": character = new Archer(name, health); break;
                case "4": character = new Healer(name, health); break;
                default:
                    Console.WriteLine("Invalid type!");
                    return;
            }
            manager.AddCharacter(character);
            Console.WriteLine($"{character.Name} added successfully!");
        }

        // Apply damage to a selected character
        static void DamageCharacter(Manager manager)
        {
            var characters = manager.GetCharacters();
            if (characters.Count == 0) { Console.WriteLine("No characters available."); return; }
            Console.WriteLine("Select character number to apply damage:");
            for (int i = 0; i < characters.Count; i++)
                Console.WriteLine($"{i + 1}. {characters[i].Name} (Health: {characters[i].Health})");
            Console.Write("Your choice: ");
            int idx = int.TryParse(Console.ReadLine(), out int n) ? n - 1 : -1;
            if (idx < 0 || idx >= characters.Count) { Console.WriteLine("Invalid number!"); return; }
            Console.Write("Damage value: ");
            int dmg = int.TryParse(Console.ReadLine(), out int d) ? d : 10;
            characters[idx].TakeDamage(dmg);
            Console.WriteLine($"{dmg} damage applied to {characters[idx].Name}.");
        }

        // Use special ability for a selected character
        static void UseSpecialAbility(Manager manager)
        {
            var characters = manager.GetCharacters();
            if (characters.Count == 0) { Console.WriteLine("No characters available."); return; }
            Console.WriteLine("Select character number to use special ability:");
            for (int i = 0; i < characters.Count; i++)
                Console.WriteLine($"{i + 1}. {characters[i].Name} (Level: {characters[i].Level}, Exp: {characters[i].Experience})");
            Console.Write("Your choice: ");
            int idx = int.TryParse(Console.ReadLine(), out int n) ? n - 1 : -1;
            if (idx < 0 || idx >= characters.Count) { Console.WriteLine("Invalid number!"); return; }
            characters[idx].SpecialAbility();
        }
    }
}
