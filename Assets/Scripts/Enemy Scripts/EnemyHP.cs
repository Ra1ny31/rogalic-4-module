using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrentHealth;
    public Animator animator;
    private Rigidbody2D rb;
    private BoxCollider2D Collider;
    private int DeathTimer = 0;

    private void Start()
    {
        CurrentHealth = MaxHealth;
        rb = GetComponent<Rigidbody2D>();
        Collider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if(DeathTimer == 1)
        {
            Destroy(gameObject);
        }
    }



    public void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;
        
        if(CurrentHealth <= 0)
        {
            
            DeathTimer = 1;
            Collider.enabled = false;
            rb.bodyType = RigidbodyType2D.Static;
            GetComponent<enemattack>().enabled = false;
            GetComponent<EnemyBehaviour>().enabled = false;
            animator.SetTrigger("Death");
            //Destroy(gameObject);
        }
    }
}
