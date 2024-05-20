using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{

    private bool isBlockingDamage = false;

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            isBlockingDamage = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && isBlockingDamage == true)
        {
            GetComponent<enemattack>().Damage = 0;
            Destroy(collision.gameObject);
        }
    }

    public void ToggleBlockDamage(bool shouldBlock)
    {
        isBlockingDamage = shouldBlock;
    }
}
