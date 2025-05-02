using UnityEngine;

public abstract class HealthBarBase : MonoBehaviour
{
    [SerializeField] protected Health _health;

    protected virtual void OnEnable()
    {
        _health.HitPointsChanged += UpdateUI;
    }

    protected virtual void OnDisable()
    {
        _health.HitPointsChanged -= UpdateUI;
    }

    protected abstract void UpdateUI();
}
