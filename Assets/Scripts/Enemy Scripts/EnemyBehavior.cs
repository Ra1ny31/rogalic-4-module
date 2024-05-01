using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private float _speed = 3.5f;
    private Vector3 _dir;
    private SpriteRenderer _sprite;

    private void Start()
    {
        _dir = transform.right;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.1f + transform.right * _dir.x * 0.7f, 0.1f);

        if (colliders.Length > 0) _dir *= -1f;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + _dir, Time.deltaTime);
    }
}
