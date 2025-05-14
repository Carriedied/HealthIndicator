using TMPro;
using UnityEngine;

public class TextHealthBar : HealthBarBase
{
    [SerializeField] private TMP_Text _healthText;

    protected override void UpdateUI()
    {
        _healthText.text = $"{HitPoints.CurrentHitPoints}/{HitPoints.MaxHitPoints}";
    }
}
