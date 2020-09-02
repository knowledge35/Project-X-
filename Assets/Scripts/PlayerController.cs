using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private AttackDefinition demoAttack;
    public float threshold = 2f;

    NavMeshAgent agent;
    Animator anim;
    Rigidbody rb;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        anim.SetFloat("Speed", agent.velocity.magnitude);
    }
    public void MoveToTarget(Vector3 point)
    {
        if (Vector3.Distance(point, transform.position) < threshold)
        {
            return;
        }
        agent.SetDestination(point);
    }


    public void AttackTarget(GameObject target)
    {
        IAttackable attackable = target.GetComponent<IAttackable>();
        if (attackable == null) return;
        attackable.OnAttack(gameObject);

        var attack = demoAttack.CreateAttack(gameObject, target);

        demoAttack.ExecuteAttackEffecs(gameObject, target, attack);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, threshold);
    }
}
