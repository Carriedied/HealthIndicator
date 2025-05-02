using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FillSliderHealth : HealthBarBase
{
    //[SerializeField] private Health _health;
    //[SerializeField] private Slider _fillSlider;

    //private void OnEnable()
    //{
    //    _health.HealthChanged += ChangeHealth;
    //}

    //private void OnDisable()
    //{
    //    _health.HealthChanged -= ChangeHealth;
    //}

    //private void ChangeHealth()
    //{
    //    _health.HealthChanged -= ChangeHealth;

    //    _fillSlider.value = _health.CurrentHitPoints;

    //    _health.HealthChanged += ChangeHealth;
    //}

    [SerializeField] private Slider _fillSlider;

    protected override void UpdateUI()
    {
        _fillSlider.value = _health.CurrentHitPoints;
    }
}
