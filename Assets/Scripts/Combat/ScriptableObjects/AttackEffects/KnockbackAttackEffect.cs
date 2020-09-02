using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Knockback Attack Effect", menuName = "Combat/AttackEffects/KnockbackEffect")]
public class KnockbackAttackEffect : AttackEffect
{
    public float forceAmount;
    public override void OnAttack(GameObject attacker, GameObject defender, AttackDefinition attackDefinition, Attack attack)
    {
        Rigidbody rb = defender.GetComponent<Rigidbody>();
        Vector3 forceDir = (defender.transform.position - attacker.transform.position).normalized;
        forceDir.y += 0.5f;
        rb?.AddForce(forceDir * forceAmount);
    }
}
