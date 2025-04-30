using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float HitPoints { get; private set; }
    public float MaxHealth { get; private set; }

    public event Action ExecuteHealth;

    private void Awake()
    {
        MaxHealth = 100;
        HitPoints = MaxHealth;
    }

    public void RestoreHealth(float countMedicines)
    {
        HitPoints += countMedicines;

        ExecuteHealth?.Invoke();
    }

    public void TakeDamage(float damage)
    {
        HitPoints -= damage;

        ExecuteHealth?.Invoke();
    }
}
