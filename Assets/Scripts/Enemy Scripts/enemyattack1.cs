using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack1 : MonoBehaviour
{
    public EnemyBehavior Move;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Move.MoveEnemy();
        }
    }
}
