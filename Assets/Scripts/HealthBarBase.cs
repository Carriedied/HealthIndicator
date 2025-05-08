using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;

public abstract class HealthBarBase : MonoBehaviour
{
    [SerializeField] protected Health _health;
    [SerializeField] private List<ExecuteButtonBase> _changeHealthButtons;

    protected virtual void OnEnable()
    {
        foreach (var button in _changeHealthButtons)
        {
            button.HitPointsChanged += UpdateUI;
        }
    }

    protected virtual void OnDisable()
    {
        foreach (var button in _changeHealthButtons)
        {
            button.HitPointsChanged -= UpdateUI;
        }
    }

    protected abstract void UpdateUI();
}