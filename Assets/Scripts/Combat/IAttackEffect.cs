using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackEffect
{
    void OnAttack(GameObject attacker, GameObject defender, AttackDefinition attackDefinition, Attack attack);
}
