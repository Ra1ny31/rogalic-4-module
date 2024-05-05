using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<EnemyBehavior>().MoveEnemy();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.GetComponent<EnemyBehavior>().StopSpeed();
    }
}
