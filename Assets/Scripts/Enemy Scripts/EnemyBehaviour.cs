using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed = 2f;
    public float stoppingDistance = 5f;
    private Rigidbody2D rb; 
    private Transform player; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= stoppingDistance)
        {
            Vector3 dirToPlayer = player.position - transform.position;
            transform.Translate(dirToPlayer.normalized * speed * Time.deltaTime);
        }
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

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.CompareTag("Obstacle"))
        {
            speed *= -1; 
            Flip();
        }
    }

    void Flip()
    {
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}