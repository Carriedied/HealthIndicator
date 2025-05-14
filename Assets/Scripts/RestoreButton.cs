using UnityEngine;

namespace Assets.Scripts
{
    public class RestoreButton : ExecuteButtonBase
    {
        [SerializeField] private float _healingAmount;

        protected override void OnButtonClick()
        {
            HealthModifier.RestoreHealth(_healingAmount);
        }
    }
}