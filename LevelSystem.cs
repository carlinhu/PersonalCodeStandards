using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Carlinhu.CodeStandards
{
    public class LevelSystem
    {
        private int level;
        private int experience;
        private int experienceToNextLevel;
        private float expExponencialFactor;

        #region Properties
        public int Level => level;
        public int Experience => experience;
        public int ExperienceToNextLevel => experienceToNextLevel;

        #endregion

        public LevelSystem(int _level, int _experience, int _experienceToNextLevel)
        {
            level = _level;
            experience = _experience;
            experienceToNextLevel = _experienceToNextLevel;
        }

        public void AddExp(int amount)
        {
            experience += amount;
            if (experience >= experienceToNextLevel)
            {
                LevelUp();
                experience -= experienceToNextLevel;
            }
        }

        void LevelUp()
        {
            experienceToNextLevel += (int)(experienceToNextLevel * expExponencialFactor);
            level++;
        }
    }
}