using TMPro;
using UnityEngine;

public class TextHealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TMP_Text _healthText;

    private void Start()
    {
        _health.ExecuteHealth += ChangeHealth;
    }

    private void ChangeHealth()
    {
        _health.ExecuteHealth -= ChangeHealth;

        _healthText.text = $"{_health.HitPoints}/{_health.MaxHealth}";

        _health.ExecuteHealth += ChangeHealth;
    }
}
