using UnityEngine;

namespace Assets.Scripts
{
    public class DamageButton : ExecuteButtonBase
    {
        [SerializeField] private float _damageAmount;

        protected override void OnButtonClick()
        {
            _health.TakeDamage(_damageAmount);

            Execute();
        }
    }
}