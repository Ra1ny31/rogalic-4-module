using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
<<<<<<< Updated upstream
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
=======
    public GameObject ShieldGameobject;
    private void Update()
    {
        ShieldGameobject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            ShieldFunction();
        }
    }

    public void ShieldFunction()
    {
        if (Input.GetMouseButton(1))
        {
            ShieldGameobject.SetActive(true);
            GetComponent<enemattack>().Damage = 0;
>>>>>>> Stashed changes
        }
    }
}
