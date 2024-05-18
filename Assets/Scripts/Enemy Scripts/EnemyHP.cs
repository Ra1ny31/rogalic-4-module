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

    private void Start()
    {
        CurrentHealth = MaxHealth;
        rb = GetComponent<Rigidbody2D>();
        Collider = GetComponent<BoxCollider2D>();
    }

    

    public void TakeDamage(int Damage)
    {
        CurrentHealth -= Damage;
        
        if(CurrentHealth <= 0)
        {
            Collider.enabled = false;
            rb.bodyType = RigidbodyType2D.Static;
            GetComponent<enemattack>().enabled = false;
            GetComponent<EnemyBehaviour>().enabled = false;
            animator.SetTrigger("Death");
            //Destroy(gameObject);
        }
    }
}
