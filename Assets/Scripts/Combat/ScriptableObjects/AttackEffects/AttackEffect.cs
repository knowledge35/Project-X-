using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class AttackEffect : ScriptableObject, IAttackEffect
{
    public abstract void OnAttack(GameObject attacker, GameObject defender, AttackDefinition attackDefinition, Attack attack);
}
