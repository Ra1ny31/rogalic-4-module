using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
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
        }
    }
}
