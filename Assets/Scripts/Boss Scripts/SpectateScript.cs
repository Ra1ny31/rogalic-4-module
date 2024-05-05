using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpectateScript : MonoBehaviour
{
    public Transform Target;
    public float Speed = 3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
        }
    }
}
