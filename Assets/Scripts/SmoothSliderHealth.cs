using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothSliderHealth : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _smoothSlider;
    [SerializeField] private float _duration;

    private void Start()
    {
        _health.ExecuteHealth += ChangeHealth;
    }

    private void ChangeHealth()
    {
        _health.ExecuteHealth -= ChangeHealth;

        StartCoroutine(ChangeSliderValue(_smoothSlider.value, _health.HitPoints));

        _health.ExecuteHealth += ChangeHealth;
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
