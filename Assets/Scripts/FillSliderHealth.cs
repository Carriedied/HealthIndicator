using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FillSliderHealth : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _fillSlider;

    private void Start()
    {
        _health.ExecuteHealth += ChangeHealth;
    }

    private void ChangeHealth()
    {
        _health.ExecuteHealth -= ChangeHealth;

        _fillSlider.value = _health.HitPoints;

        _health.ExecuteHealth += ChangeHealth;
    }
}
