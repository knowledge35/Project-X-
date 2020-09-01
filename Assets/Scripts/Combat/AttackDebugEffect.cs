using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Attack Debug Effect", menuName = "Combat/AttackEffects/AttackDebug")]
public class AttackDebugEffect : AttackEffect
{
    public override void OnAttack(GameObject attacker, GameObject defender, AttackDefinition attackDefinition, Attack attack)
    {

        if (attack.IsCritical)
            Debug.Log("CRITICAL DAMAGE!");
        Debug.Log($"{attacker.name} attacked {defender.name} for {attackDefinition.name} - {attack.Damage} damage.");
    }
}
