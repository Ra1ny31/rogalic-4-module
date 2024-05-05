using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private float _speed = 1.5f;
    public Transform target;
    //public GameObject TriggerZone;

    private void Update()
    {
        MoveEnemy();
    }

    public void MoveEnemy()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
    }

    public void StopSpeed()
    {
        _speed = 0;
    }
}
