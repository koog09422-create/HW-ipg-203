// This class is for validating character data
namespace VideoGameCharactersWithOOP.Library
{
    public static class Validator
    {
        // Check if the name is valid (not empty)
        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        // Check if the health value is valid (greater than 0)
        public static bool IsValidHealth(int health)
        {
            return health > 0;
        }
    }
}