using UnityEngine;

namespace Assets.Scripts
{
    public class ChangeHealth : MonoBehaviour
    {
        [SerializeField] private Health _health;

        public void TakeDamage(float _damageAmount)
        {
            _health.TakeDamage(_damageAmount);
        }

        public void RestoreHealth(float _damageAmount)
        {
            _health.RestoreHealth(_damageAmount);
        }
    }
}
