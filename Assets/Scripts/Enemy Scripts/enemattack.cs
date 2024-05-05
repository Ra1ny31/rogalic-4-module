using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemattack : MonoBehaviour
{
    public GameObject Trigger;
    public float Damage = 10f;
    public float CoolDown = 0;


    private void Update()   
    {
            CoolDown += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.GetComponent<PlayerHP>() != null)
        {
            other.gameObject.GetComponent<PlayerHP>().HP -= Damage;
        }
    }


}
