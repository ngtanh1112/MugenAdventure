using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public CharacterBase characterbase;

    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public float attackRate = 0.5f;
    float nextAttackTime = 0f;
    public LayerMask enemyLayer;
    public int attackDamage;
    
    private void Start()
    {
        attackDamage = characterbase.Attack;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
