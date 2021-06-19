namespace Carlinhu.CodeStandards
{
    public class PlayerData
    {
        public Stats stats;

        public struct Stats
        {
            public int level;
            public int experience;
            public int experienceToNextLevel;
            public int currentHealth;
            public int maxHealth;
        }
    }
}