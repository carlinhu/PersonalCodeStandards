using UnityEngine;

namespace Carlinhu.CodeStandards
{
    /*Base HealthSystem class for any class with health systems*/

    public class HealthSystem : MonoBehaviour, IDamageable, IHealable
    {
        [SerializeField] private int currentHealth;
        [SerializeField] private int maxHealth;

        #region Properties
        public int CurrentHealth => currentHealth;
        public int MaxHealth => maxHealth;
        #endregion

        public void InitializeHealthSystem(int _currentHealth, int _maxHealth)
        {
            currentHealth = _currentHealth;
            maxHealth = _maxHealth;
        }

        public void DealDamage(int amount)
        {
            currentHealth -= amount;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
            if (currentHealth <= 0)
            {
                Die();
            }
        }

        public void Heal(int amount)
        {
            currentHealth += amount;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        }

        protected virtual void Die() => Debug.Log($"{gameObject.name} died!");
    }
}