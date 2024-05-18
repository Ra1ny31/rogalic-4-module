using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    public BoxCollider2D shieldCollider;

    void Start()
    {
        shieldCollider = GetComponent<BoxCollider2D>();
        shieldCollider.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ToggleShield();
        }
    }

    void ToggleShield()
    {
        shieldCollider.enabled = !shieldCollider.enabled;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (shieldCollider.enabled && other.CompareTag("Enemy"))
        {
            GetComponent<enemattack>().Damage -= 10;
            Debug.Log("ўит заблокировал урон от врага");
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (shieldCollider.enabled && other.CompareTag("Enemy"))
        {
            GetComponent<enemattack>().Damage = 0;
            Debug.Log("ўит заблокировал урон от врага");
        }
    }
}
