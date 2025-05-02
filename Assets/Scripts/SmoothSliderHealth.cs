using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothSliderHealth : HealthBarBase
{
    [SerializeField] private Slider _smoothSlider;
    [SerializeField] private float _duration;

    protected override void UpdateUI()
    {
        StartCoroutine(ChangeSliderValue(_smoothSlider.value, _health.CurrentHitPoints));
    }

    private IEnumerator ChangeSliderValue(float startValue, float targetValue)
    {
        float elapsedTime = 0f;

        while (elapsedTime < _duration)
        {
            _smoothSlider.value = Mathf.Lerp(startValue, targetValue, elapsedTime / _duration);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        _smoothSlider.value = targetValue;
    }
}
