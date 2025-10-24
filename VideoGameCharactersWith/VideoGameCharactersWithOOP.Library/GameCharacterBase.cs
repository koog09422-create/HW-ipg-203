using System; 
 namespace VideoGameCharactersWithOOP.Library
{
    public abstract class GameCharacterBase : IGameCharacter
    {
        private static int totalCharacters;
        private readonly Guid id;

        public string Name { get; set; }  
        public int Health { get; set; }  
        public int Level { get; set; }   
        public int Experience { get; set; }  
        public static int TotalCharacters => totalCharacters; // Total number of characters

        public event Action<GameCharacterBase> OnDeath; // Event for character death 
        // Constructor for base character
        protected GameCharacterBase(string name, int health, int level = 1, int experience = 0)
        {
            id = Guid.NewGuid();
            Name = name;
            Health = health;
            Level = level;
            Experience = experience;
            totalCharacters++;
        } 
        public Guid Id => id; // Unique ID for character 
        public abstract void SpecialAbility(); // Abstract method for special ability
        public abstract void LevelUp(); // Abstract method for leveling up
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Health = 0;
                OnDeath?.Invoke(this); // Trigger death event
            }
        }
    }
}