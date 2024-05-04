using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public GameObject Bullet;
    public Transform BulletPos;
    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        
    }

    private void Shoot()
    {
        if(_timer >= 2)
        {
            _timer = 0;
            Instantiate(Bullet, BulletPos.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Shoot();
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Shoot();
        }
    }
}
