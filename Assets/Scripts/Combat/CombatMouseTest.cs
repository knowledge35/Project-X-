using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMouseTest : MonoBehaviour
{
    public AttackDefinition demoAttack;
    public LayerMask layerMask;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance = 200;
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, distance, layerMask))
            {
                AttackTarget(hit.transform.gameObject);
            }
        }
    }

    void AttackTarget(GameObject target)
    {
        IAttackable attackable = target.GetComponent<IAttackable>();
        if (attackable == null) return;
        attackable.OnAttack(gameObject);

        var attack = demoAttack.CreateAttack(gameObject, target);

        demoAttack.ExecuteAttackEffecs(gameObject, target, attack);
    }
}
