using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scrolling Text", menuName = "Combat/AttackEffects/Scrolling Text")]
public class ScrollingTextEffect : AttackEffect
{
    public ScrollingText TextPrefab;

    public override void OnAttack(GameObject attacker, GameObject defender, AttackDefinition attackDefinition, Attack attack)
    {
        var text = attack.Damage.ToString();
        var scrollingText = Instantiate(TextPrefab, defender.transform.position + Vector3.up * 2f, Quaternion.identity);
        scrollingText.SetText(text);
        scrollingText.SetColor(attack.IsCritical ? Color.red : Color.yellow);
    }
}
