using UnityEngine;
using UnityEngine.UI;

public class FillSliderHealth : HealthBarBase
{
    [SerializeField] private Slider _fillSlider;

    protected override void UpdateUI()
    {
        _fillSlider.value = (HitPoints.CurrentHitPoints / (float)HitPoints.MaxHitPoints) * _fillSlider.maxValue;
    }
}
