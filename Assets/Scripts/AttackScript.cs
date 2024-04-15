using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public float Range = 0.5f;
    public Transform AttackPoint;
    public LayerMask EnemyLayerMask;
    private EnemyHP  Enem;
    public int Damage = 25;


    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        Collider2D[] hitEnemyes =  Physics2D.OverlapCircleAll(AttackPoint.position, Range, EnemyLayerMask);

        foreach(Collider2D Enem in hitEnemyes)
        {
            Enem.GetComponent<EnemyHP>().TakeDamage(Damage);
        }
    }
}
