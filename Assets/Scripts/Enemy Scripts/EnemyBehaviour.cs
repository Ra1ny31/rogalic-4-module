using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed = 3.5f; 
    public float stoppingDistance = 2.0f; 
    public float sightDistance = 5.0f; 
    private Rigidbody2D rb; 
    private Transform player; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
       
        Move();
    }

    

    void Move()
    {
       
        
            if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
            {
                if (transform.position.x < player.position.x)
                {
                    rb.velocity = new Vector2(speed, rb.velocity.y);
                }
                else
                {
                    rb.velocity = new Vector2(-speed, rb.velocity.y);
                }
            }
            else
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
        
    }

    bool CanSeePlayer()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, player.position - transform.position, sightDistance);
        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {
            return true;
        }
        return false;
    }

    

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}


