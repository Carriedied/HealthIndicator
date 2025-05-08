using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Button))]
    public abstract class ExecuteButtonBase : MonoBehaviour
    {
        [SerializeField] protected Health _health;

        private Button _changeButton;

        public event Action HitPointsChanged;

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

        public void Execute()
        {
            EventSubscription();
        }

        protected abstract void OnButtonClick();

        private void EventSubscription()
        {
            HitPointsChanged?.Invoke();
        }
    }
}
