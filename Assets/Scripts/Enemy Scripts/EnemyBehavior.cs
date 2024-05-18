using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
<<<<<<< Updated upstream
    private float _speed = 1.5f;
    public Transform target;
    //public GameObject TriggerZone;
=======
<<<<<<< HEAD
    public float speed = 3.5f; 
    public float stoppingDistance = 2.0f;
    private Rigidbody2D rb; 
    private Transform player; 
>>>>>>> Stashed changes

    private void Update()
    {
        MoveEnemy();
    }
=======
    private float _speed = 1.5f;
    public Transform target;
    //public GameObject TriggerZone;
>>>>>>> daf1106fd4b50254fdc5e22d5c7534e6dd2641f3

    public void MoveEnemy()
    {
<<<<<<< Updated upstream
        transform.position = Vector2.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
    }

    public void StopSpeed()
    {
        _speed = 0;
=======
        MoveEnemy();
    }

<<<<<<< HEAD
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
=======
    public void MoveEnemy()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
    }

    public void StopSpeed()
    {
        _speed = 0;
>>>>>>> daf1106fd4b50254fdc5e22d5c7534e6dd2641f3
>>>>>>> Stashed changes
    }
}
