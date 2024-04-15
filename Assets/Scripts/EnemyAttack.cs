using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float Speed;
    public Transform Point;
    public int PositionPoint;
    bool _movingRight;

    Transform player;
    public float StoppingDistance;

    bool _chill = false;
    bool _angry = false;
    bool _goback = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if(Vector2.Distance(transform.position, Point.position) < PositionPoint)
        {
            _chill = true;
        }

        if(Vector2.Distance(transform.position, player.position) < StoppingDistance)
        {
            _angry = true;
        }

        if (Vector2.Distance(transform.position, player.position) > StoppingDistance)
        {
            _goback = true;
        }

        if(_chill == true)
        {
            Chill();
        }

        if(_angry == true)
        {
            Angry();
        }

        if(_goback == true)
        {
            GoBack();
        }
    }

    void Chill()
    {
        if(transform.position.x > Point.position.x + PositionPoint)
        {
            _movingRight = false;
        }
        else if(transform.position.x < Point.position.x - PositionPoint)
        {
            _movingRight = true;
        }

        if(_movingRight == true)
        {
            transform.position = new Vector2(transform.position.x + Speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y);
        }
    }

    void Angry()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, Speed * Time.deltaTime);
    }

    void GoBack()
    {
        transform.position = Vector2.MoveTowards(transform.position, Point.position, Speed * Time.deltaTime);
    }
}
