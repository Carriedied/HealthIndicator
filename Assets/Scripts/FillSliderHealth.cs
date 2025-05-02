using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FillSliderHealth : HealthBarBase
{
    [SerializeField] private Slider _fillSlider;

    protected override void UpdateUI()
    {
        _fillSlider.value = _health.CurrentHitPoints;
    }
}
