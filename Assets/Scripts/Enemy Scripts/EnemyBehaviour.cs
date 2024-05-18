using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float stoppingDistance = 5f;
    public GameObject player;
    public GameObject vrag;
    public float speed;

    void Update()
    {
        Vector2 player1 = player.transform.position;
        Vector2 vrag1 = vrag.transform.position;
        player1.y = vrag1.y;

        if (Vector2.Distance(player1, vrag1) > stoppingDistance)
        {
            vrag.transform.position = Vector2.MoveTowards(vrag1, player1, speed * Time.deltaTime);
        }
    }
}