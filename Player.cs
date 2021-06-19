using UnityEngine;

namespace Carlinhu.CodeStandards
{
    public class Player : MonoBehaviour
    {
        public HealthSystem playerHealthSystem;
        public LevelSystem playerLevelSystem;

        public void InitializePlayer(PlayerData _playerData)
        {
            playerHealthSystem = GetComponent<HealthSystem>();
            playerHealthSystem.InitializeHealthSystem(_playerData.stats.currentHealth, _playerData.stats.maxHealth);
            playerLevelSystem = new LevelSystem(_playerData.stats.level, _playerData.stats.experience, _playerData.stats.experienceToNextLevel);
        }
    }
}

