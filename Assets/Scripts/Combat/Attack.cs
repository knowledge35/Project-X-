using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Attack
{
    private readonly int _damage;
    private readonly bool _isCritical;

    public int Damage => _damage;
    public bool IsCritical => _isCritical;

    public Attack(int damage, bool isCritical)
    {
        _damage = damage;
        _isCritical = isCritical;
    }
}
