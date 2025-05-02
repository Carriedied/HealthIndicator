using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action HitPointsChanged;

    public float CurrentHitPoints { get; private set; }
    public float MaxHitPoints { get; private set; }

    private void Awake()
    {
        MaxHitPoints = 100;
        CurrentHitPoints = MaxHitPoints;
    }

    public void RestoreHealth(float countMedicines)
    {
        CurrentHitPoints += countMedicines;

        HitPointsChanged?.Invoke();
    }

    public void TakeDamage(float damage)
    {
        CurrentHitPoints -= damage;

        HitPointsChanged?.Invoke();
    }
}
