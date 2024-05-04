using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    private GameObject _player;
    private Rigidbody2D _rb;
    public float Force = 3;
    public float Damage = 20;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = _player.transform.position - transform.position;
        _rb.velocity = new Vector2(direction.x, direction.y).normalized * Force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;
            Destroy(gameObject);
        }
    }


}
