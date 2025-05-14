using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Button))]
    public abstract class ExecuteButtonBase : MonoBehaviour
    {
        [SerializeField] private ChangeHealth _changeHealth;

        protected ChangeHealth HealthModifier => _changeHealth;

        private Button _changeButton;

        private void Awake()
        {
            _changeButton = GetComponent<Button>();
        }

        protected virtual void OnEnable()
        {
            _changeButton.onClick.AddListener(OnButtonClick);
        }

        protected virtual void OnDisable()
        {
            _changeButton.onClick.RemoveListener(OnButtonClick);
        }

        protected abstract void OnButtonClick();
    }
}
