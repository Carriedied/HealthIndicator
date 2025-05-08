using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float CurrentHitPoints { get; private set; }
    public float MaxHitPoints { get; private set; }

    private void Awake()
    {
        MaxHitPoints = 100;
        CurrentHitPoints = MaxHitPoints;
    }

    public void RestoreHealth(float countMedicines)
    {
        CurrentHitPoints += MakeNumberPositive(countMedicines);
    }

    public void TakeDamage(float damage)
    {
        CurrentHitPoints -= MakeNumberPositive(damage);
    }

    private float MakeNumberPositive(float number)
    {
        return Mathf.Abs(number);
    }
}
