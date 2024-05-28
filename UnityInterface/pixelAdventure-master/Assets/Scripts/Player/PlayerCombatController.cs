using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombatController : MonoBehaviour
{

    [SerializeField]
    private float
        inputTimer,
        attackRadius,
        attackDamage;
    [SerializeField]
    private Transform attackHitboxPos;
    [SerializeField]
    private LayerMask whatIsDamageable;

    private bool
        gotInput,
        isAttacking;

    private float lastInputTime = Mathf.NegativeInfinity;
    private float[] attackDetails = new float[2];

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("CanAttack", true);
    }

    private void Update()
    {
        CheckCombatInput();
        CheckAttacks();
    }

    private void CheckCombatInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gotInput = true;
            lastInputTime = Time.time;
        }
    }

    private void CheckAttacks()
    {
        if (gotInput)
        {
            if (!isAttacking)
            {
                gotInput = false;
                isAttacking = true;
                anim.SetBool("Attack", true);
                anim.SetBool("IsAttacking", isAttacking);
            }
        }

        if (Time.time >= lastInputTime + inputTimer)
        {
            gotInput = false;
        }
    }

    private void CheckAttackHitBox()
    {
        Collider2D[] detectedObjects = Physics2D.OverlapCircleAll(attackHitboxPos.position, attackRadius, whatIsDamageable);

        attackDetails[0] = attackDamage;
        attackDetails[1] = transform.position.x;

        foreach (Collider2D collider in detectedObjects)
        {
            collider.transform.parent.SendMessage("TakeDamage", attackDetails);
        }
    }

    private void FinishAttack()
    {
        isAttacking = false;
        anim.SetBool("IsAttacking", isAttacking);
        anim.SetBool("Attack", false);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackHitboxPos.position, attackRadius);
    }
}
